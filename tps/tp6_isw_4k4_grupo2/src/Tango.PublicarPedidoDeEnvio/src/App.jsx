import dayjs from "dayjs";
function App() {
  return (
    <form>
      <h1>Datos de Retiro</h1>
      <label htmlFor="tipoCarga">Tipo de Carga*</label>
      <select>
        <option value="documentacion">Documentacion</option>
        <option value="paquete">Paquete</option>
        <option value="granos">Granos</option>
        <option value="hacienda">Hacienda</option>
      </select>
      <label htmlFor="calleNum">Calle y Numero*</label>
      <input type="text" />
      <label htmlFor="localidad">Localidad*</label>
      <input type="text" />
      <label htmlFor="provincia">Provincia*</label>
      <input type="text" />
      <label htmlFor="referencia">Referencia</label>
      <input type="text" />
      <label htmlFor="fechaRetiro">Fecha de Retiro*</label>
      <input type="date" value={dayjs().format("DD-MM-YYYY")} />
      <h1>Datos de Envio</h1>
      <label htmlFor="calleNumEnvio">Calle y Numero*</label>
      <input type="text" />
      <label htmlFor="localidadEnvio">Localidad*</label>
      <input type="text" />
      <label htmlFor="provinciaEnvio">Provincia*</label>
      <input type="text" />
      <label htmlFor="referenciaEnvio">Referencia</label>
      <input type="text" />
      <label htmlFor="fechaEnvio">Fecha de Envio*</label>
      <input type="date"/>
    </form>
  );
}

export default App;
