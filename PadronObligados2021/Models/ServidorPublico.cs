using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PadronObligados2021.Models
{
    [Table("ServidoresPublicos")]
    public class ServidorPublico
    {
        public int ServidorPublicoId { get; set; }//                         1 Identificador único del registro, número consecutivo
        [StringLength(120)]
        [Display(Name = "Nombre:")]
        public string Nombres { get; set; }//                                2 Nombre completo
        [StringLength(40)]
        [Display(Name = "Apellido Paterno:")]
        public string PrimerApellido { get; set; }//                         3 Apellido paterno
        [StringLength(40)]
        [Display(Name = "Apellido Materno:")]
        public string SegundoApellido { get; set; }//                        4 Apellido materno
        [StringLength(18)]
        [Display(Name = "CURP:")]
        public string CURP { get; set; }//                                   5 Clave unica de registro de población, puede servir como identificador para el acceso al sistema
        [StringLength(10)]
        [Display(Name = "R.F.C.:")]
        public string RFC { get; set; }//                                    6 Registro federal de contribuyentes
        [StringLength(3)]
        [Display(Name = "Homoclave:")]
        public string Homoclave { get; set; }//                              7 Registro deferal de contribuyentes homoclave
        //[StringLength(1)]
        //public string Genero { get; set; }//                               8 F para Femenino y M para Masculino
        //[StringLength(2)]
        //public string PaisIdNacimiento { get; set; }//                     9 id país de nacimiento en nomenclatura OSI-3166-2	Catálogo Paises
        //[StringLength(100)]
        //public string PaisNombreNacimiento { get; set; }//                10 Nombre país de nacimiento en nomenclatura OSI-3166-2	Catálogo Paises
        //[StringLength(2)]
        //public string EntidadFederativaIdNacimiento { get; set; }//       11 Id de la entidad federativa de nacimiento a dos digitos	Catálogo Entidades Federativas
        //[StringLength(100)]
        //public string EntidadFederativaNombreNacimiento { get; set; }//   12 Nombre de la entidad federativa de nacimiento en mayusculas Catálogo Entidades Federativas
        //[StringLength(2)]
        //public string PaisIdNacionalidad { get; set; }//                  13 Id de la nacionalidad	Catálogo Paises
        //[StringLength(100)]
        //public string PaisNombreNacionalidad { get; set; }//              14 Nombre de la nacionalidad Catálogo Paises
        [StringLength(100)]
        [Display(Name = "Correo electrónico Personal:")]
        public string CorreoElectronico { get; set; }//                     15 Correo electrónico personal, es importante considerar que en la cuenta que se proporcione será el medio de recuperación de contraseña en caso de haberla olvidado
        //[StringLength(20)]
        //public string LugarDomicilio { get; set; }//                      16 Lugar en el que se encuentra el domicilio en mayusculas (EN MEXICO, EN EL EXTRANJERO)
        //[StringLength(2)]
        //public string PaisIdDomicilio { get; set; }//                     17 Id País Id del país del domicilio   Catálogo Paises
        //[StringLength(100)]
        //public string PaisNombreDomicilio { get; set; }//                 18 Nombre del país del domicilio en mayusculas Catálogo Paises
        //public int EntidadFederativaId { get; set; }//                      19 Id de la entidad federativa si el domicilio es en México Catálogo Entidades Federativas
        //[StringLength(100)]
        //public string EntidadFederativaNombreDomicilio { get; set; }//    20 Nombre de la entidad federativa en mayusculas si el domicilio es en México Catálogo Entidades Federativas
        [Display(Name = "Municipio:")]
        public int? MunicipioId { get; set; }//                              21 Id del municipio si el domicilio es en México   Catálogo Municipios
        //[StringLength(100)]
        //public string MunicipioNombre { get; set; }//                     22 Nombre del municipio en mayusculas si el domicilio es en México Catálogo Municipios
        [StringLength(50)]
        [Display(Name = "Localidad o colonia:")]
        public string LocalidadNombre { get; set; }//                       23 Descripción localidad / Colonia Nombre de la localidad si el domicilio es en México Texto, 50 caracteres
        [Display(Name = "Código Postal:")]
        public int? CodigoPostal { get; set; }//                             24 Código postal Codigo postal si el domicilio es en México Numerico, 5 
        [StringLength(50)]
        [Display(Name = "Calle:")]
        public string CalleNombre { get; set; }//                           25 Calle Nombre de la calle del domicilio
        [StringLength(10)]
        [Display(Name = "Número exterior:")]
        public string NumeroExterior { get; set; }//                        26 Número exterior del domicilio Texto, 10 caracteres
        [StringLength(10)]
        [Display(Name = "Número interior:")]
        public string NumeroInterior { get; set; }//                        27 Número interior del domicilio Texto, 10 caracteres
        //EstadoProvinciaExtranjero                                         28 Nombre del Estado o Provincia si el domicilio es en el extranjero   Texto, 100 caracteres
        //CiudadLocalidadExtranjero                                         29 Nombre de la Cuidad o Localidad si el domicilio es en el extranjero Texto, 100 caracteres
        //CódigoPostalExtranjero                                            30 Código postal si el domicilio es en el extranjero Texto, 10 caracteres
        [StringLength(10)]
        [Display(Name = "Número celular:")]
        public string NumeroCelular { get; set; }//                         31 Número celular personal Número celular personal
        [StringLength(3)]
        [Display(Name = "Estado civil:")]
        public string SituacionPersonalId { get; set; }//                   32 Clave de situación personal Clave de situación personal Texto
        //[StringLength(35)]
        //public string SituacionPersonalNombre { get; set; }//               33 Estado civil    Catálogos Situación personal / Estado civil
        [StringLength(3)]
        [Display(Name = "Régimen Matrimonial:")]
        public string RegimenMatrimonialId { get; set; }//                  34 Id Regimen matrimonial
        //[StringLength(20)]
        //public string RegimenMatrimonialNombre { get; set; }//              35 Nombre Régimen matrimonial Regimen matrimonial Catálogo de regimen matrimonial
        //OtroRegimenMatrimonial                                            36 Especificar el otro regimen matrimonial Texto, 100 caracteres
        //EntePublicoId                                                     37 Id de la institución o Ente público Catálogo Entes Públicos: Texto 5 caracteres
        //EntePublicoNombre                                                 38 Nombre de la institución o ente público en mayusculas   Catálogo Entes Públicos: Texto 100 caracteres
        //AreaAdscripcionId                                                 39 Clave del área de adscripción   Catálogo Áreas de Adscripción: Texto 5 caracteres
        //AreaAdscripionNombre                                              40 Nombre del área de adscripción en mayusculas Catálogo Áreas de Adscripción: Texto 200 caracteres
        //Cargo                                                             41 Nombre el empleo, cargo o comisión en mayusculas Texto, 150 caracteres
        //EsDerivaDeContrato                                                42 Pregunta si deriva de un contrato(SI/NO)   Texto, 2 caracteres
        //CambioDependencia                                                 43 Pregunta si cambio de dependencia o ente público en el mismo orden de gobierno(SI/NO)  Texto, 2 caracteres
        //EsCambioPorEscalafon                                              44 Pregunta el cambio fue por escalafón(SI/NO)    Texto, 2 caracteres
        [StringLength(50)]
        [Display(Name = "Número identificación oficial:")]
        public string NumeroIdentificacionOficial { get; set; }//           45 Número de identificación de una identificación oficial como el INE Texto, 50 caracteres
        //ClaveServidorPublico                                              46 Clave del servicio público Texto, 10 caracteres
        //EsNivelJefeDepartamento                                              Nivel igual a jefe de departamento u homologo o superior si/no(descripción) Texto, 11 caracteres
        //NivelEmpleo                                                       47 Nivel del empleo, cargo o comisión  Nombre del nivel del empleo, cargo o comisión(OPERATIVO, MANDO MEDIO, SUPERIOR)    Texto, 11 caracteres
        //NivelOrdenGobierno                                                48 Nivel / Orden de Gobierno(FEDERAL / ESTATAL / MUNICIPAL O ALCALDIA)    Texto, 20 caracteres
        //AmbitoPublico                                                     49 Ambito público(EJECUTIVO / LEGISLATIVO / JUDICIAL / ORGANO AUTONOMO)   Texto, 17 caracteres
        //EsContratadoHonorarios                                            50 ¿Esta contratado por honorarios?	SI / NO Texto, 2 caracteres
        [Display(Name = "Función principal:")]
        public int? FuncionPrincipalId { get; set; }//                       En lugar del 51
        //[StringLength(150)]
        //public string FuncionPrincipalNombre { get; set; }//              51 Especifique la función principal(puede seleccionar más de una opción)  Catálogo de funciones Texto,  150 caracteres
        //                                                                  52 Otra función principal  Describa la otra función principal Texto, 100 caracteres
        //                                                                  53 Fecha de toma de posesión del empleo, cargo o comisión  Fecha de toma de posesión del empleo, cargo o comisión Fecha, formato dd/mm/aaaa
        [StringLength(20)]
        [Display(Name = "Teléfono oficina:")]
        public string TelefonoOficina { get; set; }//                       54 Telefono de oficina y extensión Telefono de oficina y extensión Texto, 20 caracteres
        //                                                                  55 Domicilio del empleo, cargo o comisión  EN MËXICO O EN EL EXTRANJERO    Texto, 16 caracteres
        //                                                                  56 Calle   Nombre de la calle del domicilio    Texto, 50 caracteres
        //                                                                  57 Número exterior Número exterior del domicilio Texto, 10 caracteres
        //                                                                  58 Numero interior Número interior del domicilio Texto, 10 caracteres
        //                                                                  59 Colonia o localidad     Texto, ? caracteres
        //                                                                  60 ID del municipio    Id del municipio Catálogo Municipios: Númerico, 10
        //                                                                  61 Descripción municipio   Nombre del municipio Catálogo Municipios: Texto, 100 caracteres
        //                                                                  62 ID del municipio    Id del municipio Catálogo Municipios: Númerico, 10
        //                                                                  63 Descripción municipio   Nombre del municipio Catálogo Municipios: Texto, 100 caracteres
        //                                                                  64 ID de la entidad federativa Id de la entidad federativa Catálogo Entidades Federativas: Texto, 2 caracteres
        //                                                                  65 Descripción entidad federativa  Nombre de la entidad federativa en mayúsculas Catálogo Entidades Federativas: Texto 100 caracteres
        //                                                                  66 Código postal Codigo postal Numerico, 5 
        //                                                                  67 Monto de la remuneración mensual neta del declarante    Capturar la cantidad libre de impuestos, sin comas, sin puntos, sin centavos y sin ceros a la izquierda Númerico, 10
        [StringLength(2)]
        [Display(Name = "Serv. púb. obligado año anterior?:")]
        public string EsServidorPublicoAnioAnterior { get; set; }//         68 ¿Se desempeño como servidor público en el año inmediato anterior? 	SI / NO Texto, 2 caracteres
                                                                 //                                                                  69 Monto de los ingresos netos, recibidos durante el tiempo en el que se desempeñó como servidor público en el año inmediato anterior  Capturar la cantidad libre de impuestos, sin comas, sin puntos, sin centavos y sin ceros a la izquierda Númerico, 10

        //                                                                   1 ID Identificador único del registro, número consecutivo    Número entero, sin decimales
        //                                                                   2 Nombre(s)   Nombre completo Texto, 40 caracteres
        //                                                                   3 Primer apellido Apellido paterno Texto, 40 caracteres
        //                                                                   4 Segundo apellido Apellido materno Texto, 40 caracteres
        [StringLength(3)]
        [Display(Name = "Grado maximo de estudios:")]
        public string NivelEscolarId { get; set; }//                         5 Clave del Nivel Clave del nivel de escolaridad Catálogo de Niveles escolares: Texto, 3 caracteres
        //[StringLength(30)]
        //public string NivelEscolarNombre { get; set; }//                   6 Descripción del Nivel   Descripción del nivel Catálogo de Niveles escolares: Texto, 30 caracteres
        [StringLength(200)]
        [Display(Name = "Institución Educativa:")]
        public string InstitucionEducativa { get; set; }//                   7 Nombre de la institución educativa  Nombre de la institución educativa Texto, 200 caracteres
        [StringLength(150)]
        [Display(Name = "Carrera o área de conoc.:")]
        public string CarreraArea { get; set; }//                            8 Carrera o área de conocimiento  carrera o área de conocimiento Texto, 150 caracteres
        [StringLength(10)]
        [Display(Name = "Estatus:")]
        public string EstatusNivelEscolaridad { get; set; }//                9 Estatus Estatus del nivel escolar(CURSANDO / TRUNCO / FINALIZADO)  Texto, 10 caracteres
        [StringLength(11)]
        [Display(Name = "Documento obtenido:")]
        public string DocumentoObtenido { get; set; }//                     10 Documento obtenido Descripción del documento obtenido(BOLETA / CERTIFICADO / CONSTANCIA / TITULO) Texto, 11 caracteres
        [DataType(DataType.Date)]
        [Display(Name = "Fecha obtención:")]
        public DateTime? FechaObtencion { get; set; }//                      11 Fecha de obtención del documento    Fecha de obtención del documento Fecha, formato dd/mm/aaaa
        [StringLength(16)]
        [Display(Name = "Lugar ubicación institución:")]
        public string LugarInstitucion { get; set; }//                      12 Lugar donde se ubica la institución educativa   Lugar donde se ubica la institución educativa(MÉXICO / EN EL EXTRANJERO)  Texto, 16 caracteres


        //                                                                   1 ID Identificador único del registro, número consecutivo    Número entero, sin decimales
        //                                                                   2 Nombre(s)   Nombre completo Texto, 40 caracteres
        //                                                                   3 Primer apellido Apellido paterno Texto, 40 caracteres
        //                                                                   4 Segundo apellido Apellido materno Texto, 40 caracteres
        [StringLength(7)]
        [Display(Name = "Sector:")]
        public string AmbitoSectorLaboral { get; set; }//                    5 Ámbito o sector en el que laboraste     PUBLICO / PRIVADO / OTRO Texto, 7 caracteres
        //                                                                   6 Describa el otro ámbito o sector laboral        Texto, 50 caracteres
        [StringLength(20)]
        [Display(Name = "Ambito:")]
        public string Nivel { get; set; }//                                  7 Nivel / Orden de gobierno FEDERAL / ESTATAL / MUNICIPAL O ALCALDIA Texto, 20 caracteres
        [StringLength(17)]
        [Display(Name = "Poder:")]
        public string AmbitoPublico { get; set; }//                          8 Ambito público EJECUTIVO / LEGISLATIVO / JUDICIAL / ORGANO AUTONOMO    Texto, 17 caracteres
        [StringLength(100)]
        [Display(Name = "Institución o Empresa:")]
        public string NombreEntePublico { get; set; }//                      9 Nombre del ente público / Nombre de la empresa, sociedad o asociación       Texto, 100 caracteres
        [StringLength(10)]
        [Display(Name = "R.F.C. Institución o empresa:")]
        public string RFCEntePublico { get; set; }//                        10 RFC del ente público / empresa, sociedad o sasociación Texto, 10 caracteres
        [StringLength(100)]
        [Display(Name = "Unidad Admva./Area:")]
        public string AreaAdscripcion { get; set; }//                       11 Area de adscripción     Texto, 100 caracteres
        [StringLength(100)]
        [Display(Name = "Puesto o Cargo desempeñado:")]
        public string EmpleoCargoComision { get; set; }//                   12 Empleo, cargo o comisión / puesto Texto, 100 caracteres
        [StringLength(100)]
        [Display(Name = "Función principal:")]
        public string FuncionPrincipalExperiencia { get; set; }//           13 Especifique la función principal Texto, 100 caracteres
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Ingreso:")]
        public DateTime? FechaIngreso { get; set; }//                        14 Fecha de ingreso        Fecha, formato dd/mm/aaaa
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Egreso:")]
        public DateTime? FechaEgreso { get; set; }//                         15 Fecha de egreso     Fecha, formato dd/mm/aaaa
        [Display(Name = "Sector:")]
        public int? SectorId { get; set; }//                                 16 ID del sector al que pertenece Númerico, 10 caracteres
                                          //[StringLength(150)]
                                          //  intpublic string SectorNombre { get; set; }//                   17 Descripción del sector al que pertenece Texto, 150 caracteres
                                          //                          18 Epecifique el otro sector al que pertenece      Texto, 100 caracteres
                                          //                          19 Lugar donde se ubica Lugar donde se ubica(MÉXICO / EN EL EXTRANJERO)    Texto, 16 caracteres
        [Display(Name = "Número Empleado:")]
        public int NumeroEmpleado { get; set; }
        //public EntidadFederativa EntidadFederativa { get; set; }
        public Municipio Municipio { get; set; }
        public SituacionPersonal SituacionPersonal { get; set; }
        public RegimenMatrimonial RegimenMatrimonial { get; set; }
        public FuncionPrincipal FuncionPrincipal { get; set; }
        public NivelEscolar NivelEscolar { get; set; }
        public Sector Sector { get; set; }
    }
}
