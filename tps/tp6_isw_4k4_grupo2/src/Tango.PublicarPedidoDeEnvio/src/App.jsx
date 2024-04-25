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
      <h1>Publicar pedido de envío</h1>

      <h2>Datos de retiro</h2>
      {/* Tipo de Carga  */}
      <label htmlFor="tipoCarga">Tipo de carga*</label>
      <select
        defaultValue="Select"
        {...register("tipoCarga", { required: true })}
      >
        <option value="null"></option>
        <option value="documentacion">Documentación</option>
        <option value="paquete">Paquete</option>
        <option value="granos">Granos</option>
        <option value="hacienda">Hacienda</option>
      </select>

      {/* Calle y Numero */}
      <label htmlFor="calleNum">Calle y número*</label>
      <input
        {...register("calleNum", {
          required: { value: true, message: "Calle y número son requeridos." },
          minLength: { value: 4, message: "El mínimo de caracteres es de 4." },
          maxLength: { value: 100, message: "El máximo de caracteres es de 100." },
        })}
        type="text"
      />
      {errors.calleNum && <span>{errors.calleNum.message}</span>}

      {/* Localidad */}
      <label htmlFor="localidad">Localidad*</label>
      <input
        {...register("localidad", {
          required: { value: true, message: "La localidad es requerida." },
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
          required: { value: true, message: "La provincia es requerida." },
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
          maxLength: { value: 200, message: "El máximo de caracteres es de 200." },
        })}
        type="text"
      />
      {errors.referencia && <span>{errors.referencia.message}</span>}

      {/* Fecha de Retiro */}
      <label htmlFor="fechaRetiro">Fecha de retiro*</label>
      <input
        {...register("fechaRetiro", {
          required: { value: true, message: "La fecha de retiro es requerida." },
        })}
        type="date"
      />
      {errors.fechaRetiro && <span>{errors.fechaRetiro.message}</span>}

      <h2>Datos de envío</h2>
      {/* Calle y Numero de Envio */}
      <label htmlFor="calleNumEnvio">Calle y número*</label>
      <input
        {...register("calleNumEnvio", {
          required: { value: true, message: "Calle y número son requeridos." },
          minLength: { value: 4, message: "El mínimo de caracteres es de 4." },
          maxLength: { value: 100, message: "El máximo de caracteres es de 100." },
        })}
        type="text"
      />
      {errors.calleNumEnvio && <span>{errors.calleNumEnvio.message}</span>}

      {/* Localidad de Envio */}
      <label htmlFor="localidadEnvio">Localidad*</label>
      <input
        {...register("localidadEnvio", {
          required: { value: true, message: "La localidad es requerida." },
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
          required: { value: true, message: "La provincia es requerida." },
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
          maxLength: { value: 200, message: "El máximo de caracteres es de 200." },
        })}
        type="text"
      />
      {errors.referenciaEnvio && <span>{errors.referenciaEnvio.message}</span>}

      {/* Fecha de Envio */}
      <label htmlFor="fechaEnvio">Fecha de envío*</label>
      <input {...register("fechaEnvio", { required: {value:true,message:"La fecha de envío es requerida."} })} type="date" />
      {errors.fechaEnvio && <span>{errors.fechaEnvio.message}</span>}

      {/* Imagenes */}
      <br />
      <lable htmlFor="imagenes">Imágenes</lable>
      <input {...register("imagenes")} type="file" />

      {/* Botones */}
      <button type="submit">Enviar</button>
      <button type="reset">Limpiar</button>
    </form>
  );
}

export default App;
