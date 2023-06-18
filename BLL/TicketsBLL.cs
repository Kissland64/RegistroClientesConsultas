using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class TicketsBLL
{
    private Context _contexto;

    public TicketsBLL(Context contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(Tickets Ticket)
    {
        if (!Existe(Ticket.TicketsId))
            return Insertar(Ticket);
        else
            return Modificar(Ticket);
    }

    public bool Existe(int TicketsId)
    {
        return _contexto.Tickets.Any(s => s.TicketsId == TicketsId);
    }

    private bool Insertar(Tickets Ticket)
    {
         _contexto.Tickets.Add(Ticket);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Modificar(Tickets Ticket)
    {
        _contexto.Update(Ticket);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Eliminar(Tickets tickets)
    {
        _contexto.Tickets.Remove(tickets);
        int eliminado = _contexto.SaveChanges();
        _contexto.Entry(tickets).State = EntityState.Detached;
        return eliminado > 0;
    }

    public Tickets? Buscar(int TicketId)
    {
        return _contexto.Tickets.Include(det => det.TicketsDetalles).Where(Ticket => Ticket.TicketsId == TicketId)
            .AsNoTracking()
            .SingleOrDefault();
    }

    public List<Tickets> Listar(Expression<Func<Tickets, bool>> Criterio){
        return _contexto.Tickets.Include(det => det.TicketsDetalles)
            .AsNoTracking()
            .Where(Criterio).ToList();
    }
}