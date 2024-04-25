import dayjs from "dayjs";
import { useForm } from "react-hook-form";
function App() {
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm();

  console.log("Errores", errors);

  const onSubmit = handleSubmit((data) => {
    console.log(data);
  });

  return (
    <form onSubmit={onSubmit}>
      <h1>Datos de Retiro</h1>
      {/* Tipo de Carga  */}
      <label htmlFor="tipoCarga">Tipo de Carga*</label>
      <select
        defaultValue="Select"
        {...register("tipoCarga", { required: true })}
      >
        <option value="documentacion">Documentacion</option>
        <option value="paquete">Paquete</option>
        <option value="granos">Granos</option>
        <option value="hacienda">Hacienda</option>
      </select>

      {/* Calle y Numero */}
      <label htmlFor="calleNum">Calle y Numero*</label>
      <input
        {...register("calleNum", {
          required: { value: true, message: "Calle y numero son requeridos." },
          minLength: { value: 4, message: "El minimo de caracteres es 4" },
          maxLength: { value: 100, message: "El maximo de caracteres es 100" },
        })}
        type="text"
      />
      {errors.calleNum && <span>{errors.calleNum.message}</span>}

      {/* Localidad */}
      <label htmlFor="localidad">Localidad*</label>
      <input
        {...register("localidad", {
          required: { value: true, message: "Localidad es requerida." },
          minLength: 4,
          maxLength: 100,
        })}
        type="text"
      />
      {errors.localidad && <span>{errors.localidad.message}</span>}
      {/* Provincia */}
      <label htmlFor="provincia">Provincia*</label>
      <input
        defaultValue="Córdoba"
        {...register("provincia", {
          required: { value: true, message: "Provincia es requerida." },
          minLength: 4,
          maxLength: 100,
        })}
        type="text"
      />
      {errors.provincia && <span>{errors.provincia.message}</span>}

      {/* Referencia */}
      <label htmlFor="referencia">Referencia</label>
      <input
        {...register("referencia", {
          maxLength: { value: 200, message: "El maximo de caracteres es 200" },
        })}
        type="text"
      />
      {errors.referencia && <span>{errors.referencia.message}</span>}

      {/* Fecha de Retiro */}
      <label htmlFor="fechaRetiro">Fecha de Retiro*</label>
      <input
        {...register("fechaRetiro", {
          required: { value: true, message: "Fecha de retiro es requerida." },
        })}
        type="date"
      />
      {errors.fechaRetiro && <span>{errors.fechaRetiro.message}</span>}

      <h1>Datos de Envio</h1>
      {/* Calle y Numero de Envio */}
      <label htmlFor="calleNumEnvio">Calle y Numero*</label>
      <input
        {...register("calleNumEnvio", {
          required: { value: true, message: "Calle y numero son requeridos." },
          minLength: { value: 4, message: "El minimo de caracteres es 4" },
          maxLength: { value: 100, message: "El maximo de caracteres es 100" },
        })}
        type="text"
      />
      {errors.calleNumEnvio && <span>{errors.calleNumEnvio.message}</span>}

      {/* Localidad de Envio */}
      <label htmlFor="localidadEnvio">Localidad*</label>
      <input
        {...register("localidadEnvio", {
          required: { value: true, message: "Localidad es requerida" },
          minLength: 4,
          maxLength: 100,
        })}
        type="text"
      />
      {errors.localidadEnvio && <span>{errors.localidadEnvio.message}</span>}

      {/* Provincia de Envio */}
      <label htmlFor="provinciaEnvio">Provincia*</label>
      <input
        defaultValue="Córdoba"
        {...register("provinciaEnvio", {
          required: { value: true, message: "Provincia es requerida" },
          minLength: 4,
          maxLength: 100,
        })}
        type="text"
      />
      {errors.provinciaEnvio && <span>{errors.provinciaEnvio.message}</span>}

      {/* Referencia de Envio */}
      <label htmlFor="referenciaEnvio">Referencia</label>
      <input
        {...register("referenciaEnvio", {
          maxLength: { value: 200, message: "El maximo de caracteres es 200" },
        })}
        type="text"
      />
      {errors.referenciaEnvio && <span>{errors.referenciaEnvio.message}</span>}

      {/* Fecha de Envio */}
      <label htmlFor="fechaEnvio">Fecha de Envio*</label>
      <input {...register("fechaEnvio", { required: {value:true,message:"Fecha de Envio es requerida."} })} type="date" />
      {errors.fechaEnvio && <span>{errors.fechaEnvio.message}</span>}

      {/* Imagenes */}
      <br />
      <lable htmlFor="imagenes">Imagenes</lable>
      <input {...register("imagenes")} type="file" />

      {/* Botones */}
      <button type="submit">Enviar</button>
      <button type="reset">Limpiar</button>
    </form>
  );
}

export default App;
