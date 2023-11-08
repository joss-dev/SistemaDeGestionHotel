using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;


namespace SistemaDeGestionHotel
{
    public class FacturaHtml
    {
        ClienteController cliente_controller = new ClienteController();
        UsuarioController usuario_controller = new UsuarioController();
        HabitacionController habitacion_controller = new HabitacionController();
        OfertaRecargoControllers ofertarecargo_controller = new OfertaRecargoControllers();

        public string GeneraFactura(Pago pago, Registro registro)
        {
            Cliente cliente = cliente_controller.GetClienteByID(registro.IdCliente);
            Usuario usuario = usuario_controller.GetUsuarioByID(registro.IdUsuario);
            Habitacion habitacion = habitacion_controller.GetHabitacionByID(registro.NroHabitacion);
            OfertasRecargo ofertaRecargo = null;    

            TimeSpan diferencia = registro.FechaSalida - registro.FechaIngreso;

            double montoEstadia = registro.PrecioHabPactado * diferencia.TotalDays;

            string tablaServicios = "";
            string tablaOfertaRecargos = "";
            string serviciosHtml = "";
            double subtotalServicios = 0;
            double montoOfertaRecargo = 0;
            double oferta = 0;
            double recargo = 0;

            if (registro.IdServicioAdics.Count != 0)
            {
                foreach (ServiciosAdicionale servicio in registro.IdServicioAdics)
                {
                    serviciosHtml += $@"
                <tr>
                     <td class=""service"">{servicio.NombServicio}</td>
                     <td class=""unit"">$ {servicio.Precio.ToString("N2")}</td>
                </tr>";
                    subtotalServicios += servicio.Precio;
                }

                tablaServicios = $@"
                    <table>
                    <thead>
                      <tr>
                        <th class=""service""><h3>Servicio</h3></th>
                        <th>Precio</th>
                      </tr>
                    </thead>
                    <tbody>
                      {serviciosHtml}
                      <tr>
                        <td style=""text-align: left;"" colspan=""1"">SUBTOTAL SERVICIOS</td>
                        <td class=""total"">$ {subtotalServicios.ToString("N2")}</td>
                      </tr>
                    </tbody>
                  </table>";
            }

            double subtotal = subtotalServicios + montoEstadia;

            if (pago.IdOfertaRecargo != null)
            {
                ofertaRecargo = ofertarecargo_controller.TraerORPorID(pago.IdOfertaRecargo.Value);

                if(ofertaRecargo.PorcentajeDescuento <= 0)
                {
                    recargo = (subtotal * ofertaRecargo.PorcentajeRecargo.Value) / 100;
                }else
                {
                    oferta = (subtotal * ofertaRecargo.PorcentajeDescuento.Value) / 100;
                }

                tablaOfertaRecargos = $@"
                <table>
                    <thead>
                        <tr>
                            <th class=""service""><h3>Ofertas O Recargos</h3></th>
                            <th>Porcentaje Descuento</th>
                            <th>Porcentaje Recargo</th>
                            <th>Monto Descuento</th>
                            <th>Monto Recargo</th>
                          </tr>
                    </thead>
                    <tbody>
                        <tr>
                        <td class=""service"">{ofertaRecargo.NombOfertaRecargo}</td>
                        <td class=""unit"">{(ofertaRecargo.PorcentajeDescuento / 100)?.ToString("P")}</td>
                        <td class=""unit"">{(ofertaRecargo.PorcentajeRecargo / 100)?.ToString("P")}</td>
                        <td class=""unit"">$ {oferta.ToString("N2")}</td>
                        <td class=""unit"">$ {recargo.ToString("N2")}</td>
                        </tr>
                    </tbody>
                  </table>
                  <table>";
            }



            double total = subtotal - oferta + recargo;

            // Definir una cadena que contenga HTML. Aquí es donde puedes diseñar tu factura.
            string facturaHtml = $@"
            <html>
              <head>
                <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
                <style>
                    .clearfix:after {{
                    content: """";
                    display: table;
                    clear: both;
                    }}

                    a {{
                    color: #5D6975;
                    text-decoration: underline;
                    }}

                    body {{
                    position: relative;
                    width: 21cm;  
                    height: 29.7cm; 
                    margin: 0 auto; 
                    color: #001028;
                    background: #FFFFFF; 
                    font-family: Arial, sans-serif; 
                    font-size: 12px; 
                    font-family: Arial;
                    }}

                    header {{
                    padding: 10px 0;
                    margin-bottom: 30px;
                    }}

                    #logo {{
                    text-align: center;
                    margin-bottom: 10px;
                    }}

                    #logo img {{
                    width: 90px;
                    }}

                    h1 {{
                    border-top: 1px solid  #5D6975;
                    border-bottom: 1px solid  #5D6975;
                    color: #5D6975;
                    font-size: 2.4em;
                    line-height: 1.4em;
                    font-weight: normal;
                    text-align: center;
                    margin: 0 0 20px 0;
                    background: url(dimension.png);
                    }}

                    #project {{
                    float: left;
                    }}

                    #project span {{
                    color: #5D6975;
                    text-align: right;
                    width: 52px;
                    margin-right: 10px;
                    display: inline-block;
                    font-size: 0.8em;
                    }}

                    #company {{
                    float: right;
                    text-align: right;
                    }}

                    #project div,
                    #company div {{
                    white-space: nowrap;        
                    }}

                    table {{
                    width: 100%;
                    border-collapse: collapse;
                    border-spacing: 0;
                    margin-bottom: 20px;
                    }}

                    table tr:nth-child(2n-1) td {{
                    background: #F5F5F5;
                    }}

                    table th,
                    table td {{
                    text-align: center;
                    }}

                    table th {{
                    padding: 5px 20px;
                    color: #5D6975;
                    border-bottom: 1px solid #C1CED9;
                    white-space: nowrap;        
                    font-weight: normal;
                    }}

                    table .service,
                    table .desc {{
                    text-align: left;
                    }}

                    table td {{
                    padding: 20px;
                    text-align: right;
                    }}

                    table td.service,
                    table td.desc {{
                    vertical-align: top;
                    }}

                    table td.unit,
                    table td.qty,
                    table td.total {{
                    font-size: 1.2em;
                    }}

                    table td.grand {{
                    border-top: 1px solid #5D6975;;
                    }}

                    #notices .notice {{
                    color: #5D6975;
                    font-size: 1.2em;
                    }}

                    footer {{
                    color: #5D6975;
                    width: 100%;
                    height: 30px;
                    position: absolute;
                    bottom: 0;
                    border-top: 1px solid #C1CED9;
                    padding: 8px 0;
                    text-align: center;
                    }}
                    .table-inline {{
                     display: inline-block;
                     vertical-align: top; /* Asegura que las tablas estén alineadas en la parte superior */
        
                }}
                </style>
              </head>
              <body>
                <header class=""clearfix"">
                  <h1>HOTEL PARANÁ</h1>
                  <div id=""company"" class=""clearfix"">
                    <div><b>FECHA : {DateTime.Now.ToShortDateString()}</b></div>
                    <hr>
                    <hr>
                    <div>Hotel Paraná S.A</div>
                    <hr>
                    <div>Av. 3 de Abril 1568<br /> Corrientes, Argentina</div>
                    <hr>
                    <div>+ 54 343 422 3900</div>
                    <hr>
                    <div><a href=""mailto:hotelparana@gmail.com"">hotelparana@gmail.com</a></div>
                    <hr>
                  </div>
                  <div id=""project"">
                    <div><b>NRO FACTURA : {pago.IdPago} </b><br></div>
                    <hr>
                    <hr>
                    <div><span>RAZON SOCIAL</span><br>Responsable Inscripto</div>
                    <hr>
                    <div><span>INGRESOS BRUTOS</span> <br>901-226014-2</div>
                    <hr>
                    <div><span>INICIO DE ACTIVIDADES</span><br>04/08/2009</div>
                    <hr>
                    <div><span>TIPO FACTURA</span><br>B</div>
                    <hr> 
                  </div>
                </header>
                <main>
                    <hr>
                    <br>
                    <h3>Datos del cliente</h3>
                    <div>
                        <table style=""text-align: left;"">
                            <tr style=""text-align: left;"">
                                <td style=""text-align: left;""><b>Apellido y nombre:</b></td>
                                <td style=""text-align: left;""><b>{cliente.ApellidoCliente} {cliente.NombreCliente}</b></td>
                            </tr>
                            <tr style=""text-align: left;"">
                                <td style=""text-align: left;""><b>Nro de Documento:</b></td>
                                <td style=""text-align: left;""><b>{cliente.DniCliente}</b></td>
                            </tr>
                            <tr style=""text-align: left;"">
                                <td style=""text-align: left;""> <b>Teléfono:</b></td>
                                <td style=""text-align: left;""><b>{cliente.Telefono}</b></td>
                            </tr>
                        </table>
                    </div>
                    <h3>Estadía</h3>
                    <div>
                        <table style=""display: inline-block; width: 45%;"">
                            <tr style=""text-align: left;"">
                                <td style=""text-align: left;""><b>Fecha Ingreso :</b></td>
                                <td style=""text-align: left;""><b>{registro.FechaIngreso.ToShortDateString()}</b></td>
                            </tr>
                            <tr style=""text-align: left;"">
                                <td style=""text-align: left;""><b>Fecha Salida:</b></td>
                                <td style=""text-align: left;""><b>{registro.FechaSalida.ToShortDateString()}</b></td>
                            </tr>
                            <tr style=""text-align: left;"">
                                <td style=""text-align: left;""> <b>Cantidad Huespedes:</b></td>
                                <td style=""text-align: left;""><b>{registro.CantidadHuespedes}</b></td>
                            </tr>
                            <tr style=""text-align: left;"">
                                <td style=""text-align: left;""> <b>Tipo Habitación:</b></td>
                                <td style=""text-align: left;""><b>{habitacion.IdTipoHabNavigation.NombTipo}</b></td>
                            </tr>
                            <tr style=""text-align: left;"">
                                <td style=""text-align: left;""> <b>Nro Piso:</b></td>
                                <td style=""text-align: left;""><b>{habitacion.IdPiso}</b></td>
                            </tr>
                        </table>
                        <table style=""display: inline-block; width: 45%;"">
                            <tr >
                                <td style=""text-align: right;""><b>Registrado por:</b></td>
                                <td style=""text-align: right;""><b>{usuario.Apellido} {usuario.Nombre}</b></td>
                            </tr>
                            <tr style=""text-align: right;"">
                                <td style=""text-align: right;""><b>Nro de Habitación:</b></td>
                                <td style=""text-align: right;""><b>{habitacion.NroHabitacion}</b></td>
                            </tr>
                            <tr style=""text-align: right;"">
                                <td style=""text-align: right;""><b>Cantidad de Servicios:</b></td>
                                <td style=""text-align: right;""><b>{registro.IdServicioAdics.Count}</b></td>
                            </tr>
                            <tr style=""text-align: right;"">
                                <td style=""text-align: right;""><b>Cantidad de dias:</b></td>
                                <td style=""text-align: right;"">{diferencia.TotalDays}</td>
                            </tr>
                            <tr style=""text-align: right;"">
                                <td style=""text-align: right;""><b>Precio Habitación:</b></td>
                                <td style=""text-align: right;""><b>$ {registro.PrecioHabPactado.ToString("N2")}</b></td>
                            </tr>
                        </table>
                        <table style=""text-align: left;"">
                            <tr>
                                <td style=""text-align: left;"" colspan=""1"">MONTO ESTADÍA</td>
                                <td style=""text-align: left;"" class=""total"">$ {montoEstadia.ToString("N2")}</td>
                              </tr>
                        </table>
                    </div>
                  {tablaServicios}
                    <table>
                       <tr>
                        <td colspan=""1"" class=""grand total"">SUBTOTAL</td>
                        <td class=""grand total"">$ {subtotal.ToString("N2")}</td>
                      </tr>
                  </table>
                  {tablaOfertaRecargos}
                   <table>
                       <tr>
                        <td colspan=""1"" class=""grand total"">TOTAL</td>
                        <td class=""grand total"">$ {total.ToString("N2")}</td>
                      </tr>
                  </table>
                </main>
              </body>
            </html>";
            return facturaHtml;
        }

        public void generarPdf(WebBrowser webBrowser1, string ruta)
        {
            // Crear un nuevo documento PDF.
            Document document = new Document();

            // Crear un nuevo escritor PDF.
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.Create));

            // Abrir el documento.
            document.Open();

            // Crear un nuevo StringReader con tu HTML.
            StringReader sr = new StringReader(webBrowser1.DocumentText);

            // Crear un nuevo HTMLWorker con tu documento.
            HTMLWorker htmlWorker = new HTMLWorker(document);

            // Parsear el HTML.
            htmlWorker.Parse(sr);

            // Cerrar el documento.
            document.Close();
        }

    }
}
