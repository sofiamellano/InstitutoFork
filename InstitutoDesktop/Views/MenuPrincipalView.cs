using InstitutoDesktop.Views;
using InstitutoDesktop.Views.Inscripciones;
using InstitutoDesktop.Views.Horarios;
using InstitutoDesktop.Views.MesasExamenes;


using InstitutoDesktop.Views.Commons;
using InstitutoDesktop.Services;
using InstitutoServices.Services.Commons;
using Microsoft.Extensions.Caching.Memory;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Models.MesasExamenes;
using Microsoft.Extensions.DependencyInjection;
using InstitutoDesktop.ViewReports;





namespace InstitutoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        bool logueado = false;
        private readonly MemoryCacheServiceWinForms _cacheService;
        private readonly IServiceProvider _serviceProvider;


        public MenuPrincipalView(MemoryCacheServiceWinForms memoryCacheService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _cacheService = memoryCacheService;
            
            _serviceProvider = serviceProvider;
            ToolButtonHorarios.Click += subMenuHorarios_Click;
            ToolButtonMesasExamenes.Click += subMenuConformacionMesasExamenes_Click;
        }


        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMenuItem9_Click(object sender, EventArgs e)
        {

        }



        private void MenuPrincipalView_Activated(object sender, EventArgs e)
        {
            //if (!logueado)
            //{
            //    IniciarSesionView iniciarSesionView = new IniciarSesionView();
            //    iniciarSesionView.ShowDialog();
            //    if (!iniciarSesionView.loginSuccessfull)
            //    {
            //        Application.Exit();
            //    }
            //    else
            //    {
            //        logueado = true;
            //    }
            //}

        }








        private void mnuDocentes_Click(object sender, EventArgs e)
        {
            DocentesViewReport docentesViewReport = ActivatorUtilities.CreateInstance<DocentesViewReport>(_serviceProvider,this);
            docentesViewReport.Show();
        }




        private void subMenuCiclosLectivos_Click(object sender, EventArgs e)
        {
            CiclosLectivosView ciclosLectivosView = ActivatorUtilities.CreateInstance<CiclosLectivosView>(_serviceProvider,this );
            ciclosLectivosView.Show();
        }

        private void subMenuAulas_Click(object sender, EventArgs e)
        {
            AulasView aulasView = ActivatorUtilities.CreateInstance<AulasView>(_serviceProvider, this);
            aulasView.Show();
        }

        private void subMenuAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosView alumnosView = ActivatorUtilities.CreateInstance<AlumnosView>(_serviceProvider,this);
            alumnosView.Show();
        }

        private void subMenuDocentes_Click(object sender, EventArgs e)
        {
            DocentesView docentesView = ActivatorUtilities.CreateInstance<DocentesView>(_serviceProvider, this);
            docentesView.Show();
        }

        private void subMenuCarreras_Click(object sender, EventArgs e)
        {
            CarrerasView carrerasView = ActivatorUtilities.CreateInstance<CarrerasView>(_serviceProvider, this);
            carrerasView.Show();
        }

        private void subMenuA�osCarreras_Click(object sender, EventArgs e)
        {
            AniosCarrerasView aniosCarreraView = ActivatorUtilities.CreateInstance<AniosCarrerasView>(_serviceProvider,this);
            aniosCarreraView.Show();
        }

        private void subMenuMaterias_Click(object sender, EventArgs e)
        {
            //var memoryCacheService = new MemoryCacheServiceWinForms(new MemoryCache(new MemoryCacheOptions()));
            //MateriasView materiasView= new MateriasView(memoryCacheService,this);
            MateriasView materiasView = ActivatorUtilities.CreateInstance<MateriasView>(_serviceProvider, this);
            materiasView.Show();
        }

        private void subMenuHoras_Click(object sender, EventArgs e)
        {
            HorasView horasView = ActivatorUtilities.CreateInstance<HorasView>(_serviceProvider, this);
            horasView.Show();
        }

        private void subMenuPeriodosHorarios_Click(object sender, EventArgs e)
        {
            PeriodosHorariosView periodoHorarioView = ActivatorUtilities.CreateInstance<PeriodosHorariosView>(_serviceProvider, this);
            periodoHorarioView.Show();
        }

        private void subMenuHorarios_Click(object sender, EventArgs e)
        {
            HorariosView horariosView = ActivatorUtilities.CreateInstance<HorariosView>(_serviceProvider,this);
            horariosView.Show();
        }

        private void subMenuTurnosEx�menes_Click(object sender, EventArgs e)
        {
            TurnosExamenesView turnoExamenesView = ActivatorUtilities.CreateInstance<TurnosExamenesView>(_serviceProvider, this);
            turnoExamenesView.Show();
        }

        private void subMenuPeriodosInscripciones_Click(object sender, EventArgs e)
        {
            PeriodosInscripcionesView periodoInscripcionView = ActivatorUtilities.CreateInstance<PeriodosInscripcionesView>(_serviceProvider, this);
            periodoInscripcionView.Show();
        }

        private void subMenuConformacionMesasExamenes_Click(object sender, EventArgs e)
        {
            MesasExamenesView mesasExamenesView = ActivatorUtilities.CreateInstance<MesasExamenesView>(_serviceProvider, this);
            mesasExamenesView.Show();
        }
    }
}
