namespace nace.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class nace : DbContext
    {
        public nace()
            : base("name=nace")
        {
        }

        public virtual DbSet<Actitud> Actitud { get; set; }
        public virtual DbSet<Administracion> Administracion { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AlumnoBanco> AlumnoBanco { get; set; }
        public virtual DbSet<AlumnoCursoGrupo> AlumnoCursoGrupo { get; set; }
        public virtual DbSet<AlumnoCursoGrupoMteria> AlumnoCursoGrupoMteria { get; set; }
        public virtual DbSet<AlumnosDesubicados> AlumnosDesubicados { get; set; }
        public virtual DbSet<AlumnosObservaciones> AlumnosObservaciones { get; set; }
        public virtual DbSet<AlumnoTutor> AlumnoTutor { get; set; }
        public virtual DbSet<AnioActual> AnioActual { get; set; }
        public virtual DbSet<Aspectos> Aspectos { get; set; }
        public virtual DbSet<AspectosDiariosCursoMateria> AspectosDiariosCursoMateria { get; set; }
        public virtual DbSet<AspectosDiariosTutor> AspectosDiariosTutor { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<BancoEntidad> BancoEntidad { get; set; }
        public virtual DbSet<Ciclo> Ciclo { get; set; }
        public virtual DbSet<ConfigColorResum> ConfigColorResum { get; set; }
        public virtual DbSet<ConfigEvalResum> ConfigEvalResum { get; set; }
        public virtual DbSet<ConfigResumEval> ConfigResumEval { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<CursoGrupo> CursoGrupo { get; set; }
        public virtual DbSet<CursoGrupoMateria> CursoGrupoMateria { get; set; }
        public virtual DbSet<CursoMateria> CursoMateria { get; set; }
        public virtual DbSet<DatosPendientesAprobacion_Alumno> DatosPendientesAprobacion_Alumno { get; set; }
        public virtual DbSet<DatosPendientesAprobacion_Tutor> DatosPendientesAprobacion_Tutor { get; set; }
        public virtual DbSet<DiaSemana> DiaSemana { get; set; }
        public virtual DbSet<Distribucion_Correo> Distribucion_Correo { get; set; }
        public virtual DbSet<EquivalenciaNotas> EquivalenciaNotas { get; set; }
        public virtual DbSet<Equivalencias_Act_NP> Equivalencias_Act_NP { get; set; }
        public virtual DbSet<EquivalenciasTiposMaterias> EquivalenciasTiposMaterias { get; set; }
        public virtual DbSet<Evaluacion> Evaluacion { get; set; }
        public virtual DbSet<Formatos_Boletines> Formatos_Boletines { get; set; }
        public virtual DbSet<GESTION_PREMATRICULA> GESTION_PREMATRICULA { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Horario_LOG> Horario_LOG { get; set; }
        public virtual DbSet<IconosValoracion> IconosValoracion { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<Incidencia> Incidencia { get; set; }
        public virtual DbSet<InformacionHijos> InformacionHijos { get; set; }
        public virtual DbSet<InformePsicopedagogico> InformePsicopedagogico { get; set; }
        public virtual DbSet<Informes_Asociados_Evaluaciones> Informes_Asociados_Evaluaciones { get; set; }
        public virtual DbSet<Ins_Alertas_Abonos_Solicitudes_Ins> Ins_Alertas_Abonos_Solicitudes_Ins { get; set; }
        public virtual DbSet<Ins_Alertas_FacturacionAdicional_Solicitudes_Ins> Ins_Alertas_FacturacionAdicional_Solicitudes_Ins { get; set; }
        public virtual DbSet<Ins_Codigos_Ind_Part> Ins_Codigos_Ind_Part { get; set; }
        public virtual DbSet<Ins_Def_ActividadExtraescolar> Ins_Def_ActividadExtraescolar { get; set; }
        public virtual DbSet<Ins_Estados_Flujo_Solicitud> Ins_Estados_Flujo_Solicitud { get; set; }
        public virtual DbSet<Ins_Estados_Flujo_Solicitud_Baja> Ins_Estados_Flujo_Solicitud_Baja { get; set; }
        public virtual DbSet<Ins_Inscripciones> Ins_Inscripciones { get; set; }
        public virtual DbSet<Ins_Motivos_Rechazo_Solicitud_Baja> Ins_Motivos_Rechazo_Solicitud_Baja { get; set; }
        public virtual DbSet<Ins_Motivos_Rechazo_Solicitud_PreInscripcion> Ins_Motivos_Rechazo_Solicitud_PreInscripcion { get; set; }
        public virtual DbSet<Ins_Solicitud_Baja_Inscripcion> Ins_Solicitud_Baja_Inscripcion { get; set; }
        public virtual DbSet<Ins_Solicitudes_Ins_Horario> Ins_Solicitudes_Ins_Horario { get; set; }
        public virtual DbSet<Ins_Solicitudes_Ins_ListaEspera_Horario> Ins_Solicitudes_Ins_ListaEspera_Horario { get; set; }
        public virtual DbSet<Ins_Tabla_Alertas_Facturacion> Ins_Tabla_Alertas_Facturacion { get; set; }
        public virtual DbSet<Ins_Tabla_Estados_Alerta> Ins_Tabla_Estados_Alerta { get; set; }
        public virtual DbSet<Ins_Tabla_Estados_Flujo_ListaEspera> Ins_Tabla_Estados_Flujo_ListaEspera { get; set; }
        public virtual DbSet<Ins_Tabla_Pantalla_GestionInscripciones> Ins_Tabla_Pantalla_GestionInscripciones { get; set; }
        public virtual DbSet<Ins_Tabla_Usuarios_ResponsablesExtraescolares> Ins_Tabla_Usuarios_ResponsablesExtraescolares { get; set; }
        public virtual DbSet<Ins_Tabla_Usuarios_ResponsablesFacturacion> Ins_Tabla_Usuarios_ResponsablesFacturacion { get; set; }
        public virtual DbSet<Ins_TarifasExtraescolares> Ins_TarifasExtraescolares { get; set; }
        public virtual DbSet<Ins_TipoActividadSegunGestion> Ins_TipoActividadSegunGestion { get; set; }
        public virtual DbSet<Ins_TipoGestionModulos> Ins_TipoGestionModulos { get; set; }
        public virtual DbSet<Intervalos_Horarios> Intervalos_Horarios { get; set; }
        public virtual DbSet<Libros> Libros { get; set; }
        public virtual DbSet<LibrosCursoMateria> LibrosCursoMateria { get; set; }
        public virtual DbSet<LINKS_CURSOGRUPO> LINKS_CURSOGRUPO { get; set; }
        public virtual DbSet<Literales> Literales { get; set; }
        public virtual DbSet<LiteralesInformes> LiteralesInformes { get; set; }
        public virtual DbSet<LiteralInfResumEval> LiteralInfResumEval { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<MedidasEducativas> MedidasEducativas { get; set; }
        public virtual DbSet<Mensajes_Correo_Interno> Mensajes_Correo_Interno { get; set; }
        public virtual DbSet<MOSS_PaginasRole> MOSS_PaginasRole { get; set; }
        public virtual DbSet<MOSS_Permisos_SiteLists> MOSS_Permisos_SiteLists { get; set; }
        public virtual DbSet<MOSS_RolesMOSS> MOSS_RolesMOSS { get; set; }
        public virtual DbSet<MOSS_Site> MOSS_Site { get; set; }
        public virtual DbSet<MOSS_SiteListsNames> MOSS_SiteListsNames { get; set; }
        public virtual DbSet<MOSS_SitePlantilla> MOSS_SitePlantilla { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<NotaAlumno> NotaAlumno { get; set; }
        public virtual DbSet<NotaAlumnoObservacion> NotaAlumnoObservacion { get; set; }
        public virtual DbSet<NotaAspecto> NotaAspecto { get; set; }
        public virtual DbSet<NotaAspectosDiariosCursoMateria> NotaAspectosDiariosCursoMateria { get; set; }
        public virtual DbSet<NotaAspectosDiariosTutor> NotaAspectosDiariosTutor { get; set; }
        public virtual DbSet<NotaRecuperacion> NotaRecuperacion { get; set; }
        public virtual DbSet<ObservGenerica> ObservGenerica { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<ParamInformeConf> ParamInformeConf { get; set; }
        public virtual DbSet<PlantillaCorreo> PlantillaCorreo { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Profesor_Firma_Pasar_Lista> Profesor_Firma_Pasar_Lista { get; set; }
        public virtual DbSet<ProfesorCursoGrupoMateria> ProfesorCursoGrupoMateria { get; set; }
        public virtual DbSet<Promocion> Promocion { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Registro_Pasar_Lista> Registro_Pasar_Lista { get; set; }
        public virtual DbSet<Roles_Correo> Roles_Correo { get; set; }
        public virtual DbSet<TablasTraducidas> TablasTraducidas { get; set; }
        public virtual DbSet<Tipo_Alcance_Correo> Tipo_Alcance_Correo { get; set; }
        public virtual DbSet<Tipo_InformePsicopedagogico> Tipo_InformePsicopedagogico { get; set; }
        public virtual DbSet<Tipo_Lateralidad> Tipo_Lateralidad { get; set; }
        public virtual DbSet<Tipo_RRHH> Tipo_RRHH { get; set; }
        public virtual DbSet<TipoDocIdentidad> TipoDocIdentidad { get; set; }
        public virtual DbSet<TipoHorario> TipoHorario { get; set; }
        public virtual DbSet<TipoIncidencia> TipoIncidencia { get; set; }
        public virtual DbSet<TipoMateria> TipoMateria { get; set; }
        public virtual DbSet<TipoObservacion> TipoObservacion { get; set; }
        public virtual DbSet<TipoPlantilla> TipoPlantilla { get; set; }
        public virtual DbSet<TiposOpciones_PasarLista> TiposOpciones_PasarLista { get; set; }
        public virtual DbSet<Traducciones> Traducciones { get; set; }
        public virtual DbSet<Tutor> Tutor { get; set; }
        public virtual DbSet<UNTIS_PRECARGA_CV> UNTIS_PRECARGA_CV { get; set; }
        public virtual DbSet<ValoracionAspecto> ValoracionAspecto { get; set; }
        public virtual DbSet<ValoracionAspectosDiariosCursoMateria> ValoracionAspectosDiariosCursoMateria { get; set; }
        public virtual DbSet<ValoracionAspectosDiariosTutor> ValoracionAspectosDiariosTutor { get; set; }
        public virtual DbSet<Aceptacion_Usuarios> Aceptacion_Usuarios { get; set; }
        public virtual DbSet<Act_NP_Alumno> Act_NP_Alumno { get; set; }
        public virtual DbSet<Act_PE_Alumno> Act_PE_Alumno { get; set; }
        public virtual DbSet<Alumnos_Hijos_Empleados> Alumnos_Hijos_Empleados { get; set; }
        public virtual DbSet<Alumnos_Recibidos_Traspaso> Alumnos_Recibidos_Traspaso { get; set; }
        public virtual DbSet<CARGA_EMPLEADOS> CARGA_EMPLEADOS { get; set; }
        public virtual DbSet<Conf_Alertas_Incidencias_Niveles> Conf_Alertas_Incidencias_Niveles { get; set; }
        public virtual DbSet<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares { get; set; }
        public virtual DbSet<ConfigAD> ConfigAD { get; set; }
        public virtual DbSet<ConfigCAV> ConfigCAV { get; set; }
        public virtual DbSet<CONFIGCORREO> CONFIGCORREO { get; set; }
        public virtual DbSet<Correos_Electronicos_Aviso_RRHH> Correos_Electronicos_Aviso_RRHH { get; set; }
        public virtual DbSet<DatosPendientesAprobacion_Profesor> DatosPendientesAprobacion_Profesor { get; set; }
        public virtual DbSet<EMPLEADOS_GRUPO> EMPLEADOS_GRUPO { get; set; }
        public virtual DbSet<Equivalencias_Act_PE> Equivalencias_Act_PE { get; set; }
        public virtual DbSet<Equivalencias_Descuentos> Equivalencias_Descuentos { get; set; }
        public virtual DbSet<Ins_HorarioActividad> Ins_HorarioActividad { get; set; }
        public virtual DbSet<Ins_Log_PromocionExtraescolares> Ins_Log_PromocionExtraescolares { get; set; }
        public virtual DbSet<Ins_Tabla_Alertas_Abonos> Ins_Tabla_Alertas_Abonos { get; set; }
        public virtual DbSet<Ins_Tabla_Estados_Inscripcion> Ins_Tabla_Estados_Inscripcion { get; set; }
        public virtual DbSet<Ins_Tabla_Modulos_Minimos> Ins_Tabla_Modulos_Minimos { get; set; }
        public virtual DbSet<Justificaciones_Ausencias_Alumnos> Justificaciones_Ausencias_Alumnos { get; set; }
        public virtual DbSet<Log_Mod_NotasAlumno> Log_Mod_NotasAlumno { get; set; }
        public virtual DbSet<Log_Mod_NotasRecuperacion> Log_Mod_NotasRecuperacion { get; set; }
        public virtual DbSet<Log_Registro_Pasar_Lista_Familiares> Log_Registro_Pasar_Lista_Familiares { get; set; }
        public virtual DbSet<Log_Sesion_Profesor_Dentro_Horario> Log_Sesion_Profesor_Dentro_Horario { get; set; }
        public virtual DbSet<Log_Sesion_Profesor_Fuera_Horario> Log_Sesion_Profesor_Fuera_Horario { get; set; }
        public virtual DbSet<Registro_Alertas_SMS> Registro_Alertas_SMS { get; set; }
        public virtual DbSet<Registro_Firmas_Pasar_Lista> Registro_Firmas_Pasar_Lista { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administracion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Administracion>()
                .Property(e => e.Apellido1)
                .IsUnicode(false);

            modelBuilder.Entity<Administracion>()
                .Property(e => e.Apellido2)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Apellido1)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Apellido2)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.CodMatricula)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.CIP)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.DocIdentidad)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.NSS)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Tlf1)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Tlf2)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.DocOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.NScta)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.DESCUENTO_ESCOLARIDAD)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.DESCUENTO_COMEDOR)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Act_NP_Alumno)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Act_PE_Alumno)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnoBanco)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnoCursoGrupo)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnoCursoGrupoMteria)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Alumnos_Recibidos_Traspaso)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnosDesubicados)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnosObservaciones)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnoTutor)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.DatosPendientesAprobacion_Alumno)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.GESTION_PREMATRICULA)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Incidencia)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Justificaciones_Ausencias_Alumnos)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.NotaAlumno)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.NotaAspecto)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.NotaAspectosDiariosCursoMateria)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.NotaAspectosDiariosTutor)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Registro_Pasar_Lista)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlumnoCursoGrupo>()
                .Property(e => e.NotaFinal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Aspectos>()
                .HasMany(e => e.NotaAspecto)
                .WithRequired(e => e.Aspectos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspectosDiariosCursoMateria>()
                .HasMany(e => e.ValoracionAspectosDiariosCursoMateria)
                .WithRequired(e => e.AspectosDiariosCursoMateria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspectosDiariosTutor>()
                .HasMany(e => e.ValoracionAspectosDiariosTutor)
                .WithRequired(e => e.AspectosDiariosTutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.Oficina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.DC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.NumCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.NIF)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.CPTit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.PoblacionTit)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.IBAN)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.AlumnoBanco)
                .WithRequired(e => e.Banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BancoEntidad>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BancoEntidad>()
                .HasMany(e => e.Banco)
                .WithRequired(e => e.BancoEntidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ciclo>()
                .HasMany(e => e.Curso)
                .WithRequired(e => e.Ciclo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConfigColorResum>()
                .Property(e => e.Anyo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConfigEvalResum>()
                .Property(e => e.Anyo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConfigResumEval>()
                .Property(e => e.Anyo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.CodCurso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.NumFamDimoni)
                .IsFixedLength();

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.AspectosDiariosTutor)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Curso1)
                .WithOptional(e => e.Curso2)
                .HasForeignKey(e => e.IdCursoSiguiente);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.CursoGrupo)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.CursoMateria)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.GESTION_PREMATRICULA)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupo>()
                .Property(e => e.Grupo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CursoGrupo>()
                .Property(e => e.Anyo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CursoGrupo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CursoGrupo>()
                .Property(e => e.NumFamDimoni)
                .IsFixedLength();

            modelBuilder.Entity<CursoGrupo>()
                .HasMany(e => e.AlumnoCursoGrupo)
                .WithRequired(e => e.CursoGrupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupo>()
                .HasMany(e => e.AlumnosDesubicados)
                .WithRequired(e => e.CursoGrupo)
                .HasForeignKey(e => e.IdCursoGrupoDesubicado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupo>()
                .HasMany(e => e.AlumnosObservaciones)
                .WithRequired(e => e.CursoGrupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupo>()
                .HasMany(e => e.CursoGrupoMateria)
                .WithRequired(e => e.CursoGrupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupo>()
                .HasMany(e => e.LINKS_CURSOGRUPO)
                .WithRequired(e => e.CursoGrupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupo>()
                .HasMany(e => e.NotaAspectosDiariosTutor)
                .WithRequired(e => e.CursoGrupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupoMateria>()
                .Property(e => e.CodMateria)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CursoGrupoMateria>()
                .HasMany(e => e.AlumnoCursoGrupoMteria)
                .WithRequired(e => e.CursoGrupoMateria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupoMateria>()
                .HasMany(e => e.LibrosCursoMateria)
                .WithRequired(e => e.CursoGrupoMateria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupoMateria>()
                .HasMany(e => e.NotaAlumno)
                .WithRequired(e => e.CursoGrupoMateria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupoMateria>()
                .HasMany(e => e.ProfesorCursoGrupoMateria)
                .WithRequired(e => e.CursoGrupoMateria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoGrupoMateria>()
                .HasMany(e => e.Registro_Pasar_Lista)
                .WithRequired(e => e.CursoGrupoMateria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoMateria>()
                .Property(e => e.CodMateria)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CursoMateria>()
                .HasMany(e => e.Aspectos)
                .WithRequired(e => e.CursoMateria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CursoMateria>()
                .HasMany(e => e.AspectosDiariosCursoMateria)
                .WithRequired(e => e.CursoMateria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Alumno>()
                .Property(e => e.DocIdentidad)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Alumno>()
                .Property(e => e.PoblacionContacto)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Alumno>()
                .Property(e => e.CPContacto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Alumno>()
                .Property(e => e.DireccionContacto)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Alumno>()
                .Property(e => e.EmailContacto)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Alumno>()
                .Property(e => e.Tlf1)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Alumno>()
                .Property(e => e.Tlf2)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.Tlf1)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.Tlf2)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.SMS)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.SMSX)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.PoblacionContacto)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.CP_Contacto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Tutor>()
                .Property(e => e.Direccion_Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Act_NP>()
                .Property(e => e.CodArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Act_NP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Act_NP>()
                .Property(e => e.Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Act_NP>()
                .Property(e => e.CentroCoste)
                .IsUnicode(false);

            modelBuilder.Entity<Evaluacion>()
                .HasMany(e => e.AlumnosObservaciones)
                .WithRequired(e => e.Evaluacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Evaluacion>()
                .HasMany(e => e.ConfigEvalResum)
                .WithRequired(e => e.Evaluacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Evaluacion>()
                .HasMany(e => e.NotaAlumno)
                .WithRequired(e => e.Evaluacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Evaluacion>()
                .HasMany(e => e.NotaAspecto)
                .WithRequired(e => e.Evaluacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.Profesor_Firma_Pasar_Lista)
                .WithRequired(e => e.Horario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.Traducciones)
                .WithRequired(e => e.Idioma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.PlantillaCorreo)
                .WithRequired(e => e.Idioma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Intervalos_Horarios>()
                .HasOptional(e => e.Intervalos_Horarios1)
                .WithRequired(e => e.Intervalos_Horarios2);

            modelBuilder.Entity<Libros>()
                .Property(e => e.Editorial)
                .IsFixedLength();

            modelBuilder.Entity<Libros>()
                .HasMany(e => e.LibrosCursoMateria)
                .WithRequired(e => e.Libros)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LibrosCursoMateria>()
                .Property(e => e.Grupo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.EquivalenciaNotas)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.InformacionHijos)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.LINKS_CURSOGRUPO)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares)
                .WithRequired(e => e.Literales)
                .HasForeignKey(e => e.Literal_Extraescolares)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares1)
                .WithRequired(e => e.Literales1)
                .HasForeignKey(e => e.Literal_FirmaFamiliar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares2)
                .WithRequired(e => e.Literales2)
                .HasForeignKey(e => e.Literal_Titulo_Evaluacion1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares3)
                .WithRequired(e => e.Literales3)
                .HasForeignKey(e => e.Literal_Titulo_Evaluacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares4)
                .WithRequired(e => e.Literales4)
                .HasForeignKey(e => e.Literal_Titulo_Evaluacion2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares5)
                .WithRequired(e => e.Literales5)
                .HasForeignKey(e => e.Literal_Titulo_Evaluacion3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares6)
                .WithRequired(e => e.Literales6)
                .HasForeignKey(e => e.Literal_Titulo_Evaluacion4)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares7)
                .WithRequired(e => e.Literales7)
                .HasForeignKey(e => e.Literal_Titulo_Historico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares8)
                .WithRequired(e => e.Literales8)
                .HasForeignKey(e => e.Literal_Titulo_Materia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares9)
                .WithRequired(e => e.Literales9)
                .HasForeignKey(e => e.Literal_Titulo_ObservacionesActividades)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares10)
                .WithRequired(e => e.Literales10)
                .HasForeignKey(e => e.Literal_Nombre_Colegio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares11)
                .WithRequired(e => e.Literales11)
                .HasForeignKey(e => e.Literal_Titulo_ObservacionesFamiliar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares12)
                .WithRequired(e => e.Literales12)
                .HasForeignKey(e => e.Literal_Sello_Colegio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares13)
                .WithRequired(e => e.Literales13)
                .HasForeignKey(e => e.Literal_Titulo_Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares14)
                .WithRequired(e => e.Literales14)
                .HasForeignKey(e => e.Literal_Titulo_Calificacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares15)
                .WithRequired(e => e.Literales15)
                .HasForeignKey(e => e.Literal_Titulo_Colegio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares16)
                .WithRequired(e => e.Literales16)
                .HasForeignKey(e => e.Literal_Titulo_Colegio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Conf_Boletin_Extraescolares17)
                .WithRequired(e => e.Literales17)
                .HasForeignKey(e => e.Literal_Titulo_CursoAcademico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Tipo_InformePsicopedagogico)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Roles_Correo)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Tipo_Alcance_Correo)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Tipo_Lateralidad)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.TipoIncidencia)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.Traducciones)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Literales>()
                .HasMany(e => e.ValoracionAspecto)
                .WithRequired(e => e.Literales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materia>()
                .Property(e => e.CodMateria)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Materia>()
                .HasMany(e => e.CursoGrupoMateria)
                .WithRequired(e => e.Materia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materia>()
                .HasMany(e => e.CursoMateria)
                .WithRequired(e => e.Materia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MOSS_RolesMOSS>()
                .HasMany(e => e.MOSS_PaginasRole)
                .WithRequired(e => e.MOSS_RolesMOSS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MOSS_RolesMOSS>()
                .HasMany(e => e.MOSS_Permisos_SiteLists)
                .WithRequired(e => e.MOSS_RolesMOSS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MOSS_Site>()
                .HasMany(e => e.MOSS_SitePlantilla)
                .WithRequired(e => e.MOSS_Site)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MOSS_SiteListsNames>()
                .HasMany(e => e.MOSS_Permisos_SiteLists)
                .WithRequired(e => e.MOSS_SiteListsNames)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .Property(e => e.CodNivel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.Ciclo)
                .WithRequired(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.ConfigEvalResum)
                .WithRequired(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.ConfigResumEval)
                .WithRequired(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.EquivalenciaNotas)
                .WithRequired(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.EquivalenciasTiposMaterias)
                .WithRequired(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.Evaluacion)
                .WithRequired(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.Intervalos_Horarios)
                .WithRequired(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.ValoracionAspecto)
                .WithRequired(e => e.Nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotaAlumno>()
                .Property(e => e.Actitud)
                .IsUnicode(false);

            modelBuilder.Entity<NotaAlumno>()
                .Property(e => e.Medidas)
                .IsUnicode(false);

            modelBuilder.Entity<NotaAlumno>()
                .Property(e => e.Recomendacion)
                .IsUnicode(false);

            modelBuilder.Entity<NotaAlumno>()
                .HasMany(e => e.NotaAlumnoObservacion)
                .WithRequired(e => e.NotaAlumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotaAlumno>()
                .HasMany(e => e.NotaAspecto)
                .WithRequired(e => e.NotaAlumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotaAlumno>()
                .HasMany(e => e.NotaRecuperacion)
                .WithRequired(e => e.NotaAlumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotaAspecto>()
                .Property(e => e.Actitud)
                .IsUnicode(false);

            modelBuilder.Entity<NotaAspecto>()
                .Property(e => e.Recomendacion)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.CodDimoni)
                .IsFixedLength();

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Alumno)
                .WithOptional(e => e.Pais)
                .HasForeignKey(e => e.IdPais);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Alumno1)
                .WithOptional(e => e.Pais1)
                .HasForeignKey(e => e.IdPais);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Alumno2)
                .WithOptional(e => e.Pais2)
                .HasForeignKey(e => e.PaisNacimiento);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.DatosPendientesAprobacion_Alumno)
                .WithOptional(e => e.Pais)
                .HasForeignKey(e => e.IdPaisContacto);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Provincia)
                .WithRequired(e => e.Pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Apellido1)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Apellido2)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.DocIdentidad)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.NSS)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Tlf1)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Tlf2)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.NUM_HORAS_CONTRATO)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.PORC_OCUPACION)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Horas_Extraescolares)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Profesor>()
                .HasMany(e => e.CursoGrupo)
                .WithOptional(e => e.Profesor)
                .HasForeignKey(e => e.IdResponsable);

            modelBuilder.Entity<Profesor>()
                .HasMany(e => e.CursoGrupo1)
                .WithOptional(e => e.Profesor1)
                .HasForeignKey(e => e.IdResponsable2);

            modelBuilder.Entity<Profesor>()
                .HasMany(e => e.ProfesorCursoGrupoMateria)
                .WithRequired(e => e.Profesor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Promocion>()
                .Property(e => e.Grupo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Promocion>()
                .Property(e => e.Anyo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.Alumno)
                .WithOptional(e => e.Provincia)
                .HasForeignKey(e => e.IdProvincia);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.Alumno1)
                .WithOptional(e => e.Provincia1)
                .HasForeignKey(e => e.ProvNacimiento);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.Banco)
                .WithRequired(e => e.Provincia)
                .HasForeignKey(e => e.IdProvinciaTit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.DatosPendientesAprobacion_Alumno)
                .WithOptional(e => e.Provincia)
                .HasForeignKey(e => e.IdProvinciaContacto);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.Profesor)
                .WithRequired(e => e.Provincia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.Tutor)
                .WithRequired(e => e.Provincia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registro_Pasar_Lista>()
                .HasMany(e => e.Log_Registro_Pasar_Lista_Familiares)
                .WithRequired(e => e.Registro_Pasar_Lista)
                .HasForeignKey(e => e.IdRegistroPasarLista)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles_Correo>()
                .HasMany(e => e.Distribucion_Correo)
                .WithRequired(e => e.Roles_Correo)
                .HasForeignKey(e => e.IDRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles_Correo>()
                .HasMany(e => e.Distribucion_Correo1)
                .WithRequired(e => e.Roles_Correo1)
                .HasForeignKey(e => e.IDRoleDestino)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_Alcance_Correo>()
                .HasMany(e => e.Distribucion_Correo)
                .WithRequired(e => e.Tipo_Alcance_Correo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_InformePsicopedagogico>()
                .HasMany(e => e.InformePsicopedagogico)
                .WithRequired(e => e.Tipo_InformePsicopedagogico)
                .HasForeignKey(e => e.TipoInforme)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_Lateralidad>()
                .HasMany(e => e.Alumno)
                .WithOptional(e => e.Tipo_Lateralidad)
                .HasForeignKey(e => e.Lateralidad);

            modelBuilder.Entity<Tipo_RRHH>()
                .HasMany(e => e.CursoGrupoMateria)
                .WithOptional(e => e.Tipo_RRHH)
                .HasForeignKey(e => e.TipoRRHH);

            modelBuilder.Entity<Tipo_RRHH>()
                .HasMany(e => e.Horario)
                .WithOptional(e => e.Tipo_RRHH)
                .HasForeignKey(e => e.TipoRRHH);

            modelBuilder.Entity<TipoDocIdentidad>()
                .Property(e => e.TipoDocIdentidad1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocIdentidad>()
                .HasMany(e => e.DatosPendientesAprobacion_Alumno)
                .WithOptional(e => e.TipoDocIdentidad)
                .HasForeignKey(e => e.TipoDoc);

            modelBuilder.Entity<TipoDocIdentidad>()
                .HasMany(e => e.Profesor)
                .WithRequired(e => e.TipoDocIdentidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoHorario>()
                .Property(e => e.TipoHorario1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoPlantilla>()
                .HasMany(e => e.PlantillaCorreo)
                .WithRequired(e => e.TipoPlantilla)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiposOpciones_PasarLista>()
                .HasMany(e => e.Registro_Pasar_Lista)
                .WithRequired(e => e.TiposOpciones_PasarLista)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Traducciones>()
                .Property(e => e.Abrev)
                .IsFixedLength();

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Apellido1)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Apellido2)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.DocIdentidad)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Tlf1)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Tlf2)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.SMS)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.SMSX)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .HasMany(e => e.AlumnoTutor)
                .WithRequired(e => e.Tutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tutor>()
                .HasMany(e => e.DatosPendientesAprobacion_Tutor)
                .WithRequired(e => e.Tutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tutor>()
                .HasMany(e => e.Log_Registro_Pasar_Lista_Familiares)
                .WithRequired(e => e.Tutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Act_NP_Alumno>()
                .Property(e => e.CodArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Act_NP_Alumno>()
                .Property(e => e.Unidades)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Act_PE_Alumno>()
                .Property(e => e.Unidades)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Act_PE_Alumno>()
                .Property(e => e.CodDescuento)
                .IsUnicode(false);

            modelBuilder.Entity<Act_PE_Alumno>()
                .Property(e => e.Documento)
                .HasPrecision(28, 10);

            modelBuilder.Entity<CARGA_EMPLEADOS>()
                .Property(e => e.HORAS_SEMANALES)
                .HasPrecision(4, 2);

            modelBuilder.Entity<CARGA_EMPLEADOS>()
                .Property(e => e.PORCENTAJE_DEDICACION)
                .HasPrecision(5, 2);

            modelBuilder.Entity<DatosPendientesAprobacion_Profesor>()
                .Property(e => e.NSS)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Profesor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Profesor>()
                .Property(e => e.Tlf1)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Profesor>()
                .Property(e => e.Tlf2)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Profesor>()
                .Property(e => e.PoblacionContacto)
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Profesor>()
                .Property(e => e.CP_Contacto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DatosPendientesAprobacion_Profesor>()
                .Property(e => e.Direccion_Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOS_GRUPO>()
                .Property(e => e.COD_EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Act_PE>()
                .Property(e => e.CodArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Act_PE>()
                .Property(e => e.Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Act_PE>()
                .Property(e => e.CentroCoste)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Descuentos>()
                .Property(e => e.CodDescuento)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Descuentos>()
                .Property(e => e.Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencias_Descuentos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Log_Mod_NotasAlumno>()
                .Property(e => e.Actitud)
                .IsUnicode(false);

            modelBuilder.Entity<Log_Mod_NotasAlumno>()
                .Property(e => e.Medidas)
                .IsUnicode(false);

            modelBuilder.Entity<Log_Mod_NotasAlumno>()
                .Property(e => e.Actitud_Old)
                .IsUnicode(false);

            modelBuilder.Entity<Log_Mod_NotasAlumno>()
                .Property(e => e.Medidas_Old)
                .IsUnicode(false);
        }
    }
}
