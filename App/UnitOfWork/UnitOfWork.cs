using App.Repository;
using Domain.Interfaces;
using Persistence;

namespace App.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;

    //main
    private CategoriaPerRepository _categoriaPers;
    private CiudadRepository _ciudades;
    private ContactoPerRepository _contactoPers;
    private ContratoRepository _contratos;
    private DepartamentoRepository _departamentos;
    private DirPersonaRepository _dirPersonas;
    private EstadoRepository _estados;
    private PaisRepository _paises;
    private PersonaRepository _personas;
    private ProgramacionRepository _programaciones;
    private TipoContactoRepository _tipoContactos;
    private TipoDireccionRepository _tipoDirecciones;
    private TipoPersonaRepository _tipoPeronas;
    private TurnoRepository _turnos;
    //JWT
    private RoleRepository _roles;
    private UserRepository _users;
    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }

    //main
    public ICategoriaPer CategoriaPers
    {
        get
        {
            if (_categoriaPers == null)
            {
                _categoriaPers = new CategoriaPerRepository(_context);
            }
            return _categoriaPers;
        }
    }
    public ICiudad Ciudades
    {
        get
        {
            if (_ciudades == null)
            {
                _ciudades = new CiudadRepository(_context);
            }
            return _ciudades;
        }
    }
    public IContactoPer ContactoPers
    {
        get
        {
            if (_contactoPers == null)
            {
                _contactoPers = new ContactoPerRepository(_context);
            }
            return _contactoPers;
        }
    }
    public IContrato Contratos
    {
        get
        {
            if (_contratos == null)
            {
                _contratos = new ContratoRepository(_context);
            }
            return _contratos;
        }
    }
    public IDepartamento Departamentos
    {
        get
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }
    public IDirPersona DirPersonas
    {
        get
        {
            if (_dirPersonas == null)
            {
                _dirPersonas = new DirPersonaRepository(_context);
            }
            return _dirPersonas;
        }
    }
    public IEstado Estados
    {
        get
        {
            if (_estados == null)
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }
    public IPais Paises
    {
        get
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context);
            }
            return _paises;
        }
    }
    public IPersona Personas
    {
        get
        {
            if (_personas == null)
            {
                _personas = new PersonaRepository(_context);
            }
            return _personas;
        }
    }
    public IProgramacion Programaciones
    {
        get
        {
            if (_programaciones == null)
            {
                _programaciones = new ProgramacionRepository(_context);
            }
            return _programaciones;
        }
    }
    public ITipoContacto TipoContactos
    {
        get
        {
            if (_tipoContactos == null)
            {
                _tipoContactos = new TipoContactoRepository(_context);
            }
            return _tipoContactos;
        }
    }
    public ITipoDireccion TipoDirecciones
    {
        get
        {
            if (_tipoDirecciones == null)
            {
                _tipoDirecciones = new TipoDireccionRepository(_context);
            }
            return _tipoDirecciones;
        }
    }
    public ITipoPersona TipoPersonas
    {
        get
        {
            if (_tipoPeronas == null)
            {
                _tipoPeronas = new TipoPersonaRepository(_context);
            }
            return _tipoPeronas;
        }
    }
    public ITurno Turnos
    {
        get
        {
            if (_turnos == null)
            {
                _turnos = new TurnoRepository(_context);
            }
            return _turnos;
        }
    }

    //jwt
    public IRoleRepository Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RoleRepository(_context);
            }
            return _roles;
        }
    }

    public IUserRepository Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}