import moment from "moment";
import { useState, useEffect } from "react";
import { useForm } from "react-hook-form";
import Title from "./components/Title";
function App() {
  const {
    register,
    handleSubmit,
    watch,
    formState: { errors },
  } = useForm();

  const handleFechaEnvio = (value) => {
    let fechaRetiro = moment(watch("fechaRetiro")).format("l");
    let fechaActual = moment().format("l");
    let fechaEnvioSelec = moment(value).format("l");
    let fechaEnvioMax = moment(fechaRetiro).add(14, "day");


    if (
      new Date(fechaEnvioSelec).getTime() - new Date(fechaRetiro).getTime() <
      0
    ) {
      return "La fecha debe ser mayor o igual a la fecha de retiro.";
    }
    if (
      new Date(fechaEnvioSelec).getTime() - new Date(fechaActual).getTime() <
      0
    ) {
      return "La fecha debe ser mayor o igual a la fecha actual.";
    }
    if (moment(fechaEnvioSelec).isAfter(fechaEnvioMax)) {
      return "Maximo 14 dias de diferencia con el retiro.";
    } else {
      return true;
    }
  };

  const handleFechaRetiro = (value) => {
    let fechaSelec = new Date(moment(value).format("l")).getTime();
    let fechaActual = new Date(moment().format("l")).getTime();
    let fechaRetiroMax = new Date(moment(fechaActual).add(6,"month")).getTime();
    // console.log("actual:",fechaActual,"selec:", fechaSelec)
    if (fechaSelec < fechaActual) {
      return "La fecha debe ser mayor o igual a la fecha actual.";
    } if (fechaSelec > fechaRetiroMax)
    {
      return "La fecha de retiro no puede ser 6 meses despues de la actual."
    }else{
      return true;
    }
  };
  // console.log(new Date(watch("fechaRetiro")).getTime() - new Date(moment().format()).getTime())

  const onSubmit = handleSubmit((data) => {
    console.log(data);
  });

  return (
    <form onSubmit={onSubmit}>
      <Title text="Publicar pedido de envío" />

      <h2>Datos de retiro</h2>
      {/* Tipo de Carga  */}
      <label htmlFor="tipoCarga">Tipo de carga*</label>
      <select
        defaultValue=""
        {...register("tipoCarga", {
          required: { value: true, message: "Seleccione un tipo de carga." },
        })}
      >
        <option value="" selected disabled>
          Seleccionar...
        </option>
        <option value="documentacion">Documentación</option>
        <option value="paquete">Paquete</option>
        <option value="granos">Granos</option>
        <option value="hacienda">Hacienda</option>
      </select>
      {errors.tipoCarga && <span>{errors.tipoCarga.message}</span>}

      {/* Calle y Numero */}
      <label htmlFor="calleNum">Calle y número*</label>
      <input
        {...register("calleNum", {
          required: { value: true, message: "Calle y número son requeridos." },
          minLength: { value: 4, message: "El mínimo de caracteres es de 4." },
          maxLength: {
            value: 100,
            message: "El máximo de caracteres es de 100.",
          },
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
      {/* Provincia de retiro */}
      <label htmlFor="provinciaRetiro">Provincia*</label>
        <select
          defaultValue="cordoba"
          {...register("provinciaRetiro", {
            required: { value: true, message: "Seleccione una provincia." },
          })}
        >
          <option value="" selected disabled>Seleccionar...</option>
          <option value="buenos-aires">Buenos Aires</option>
          <option value="caba">Ciudad Autónoma de Buenos Aires</option>
          <option value="catamarca">Catamarca</option>
          <option value="chaco">Chaco</option>
          <option value="chubut">Chubut</option>
          <option value="cordoba">Córdoba</option>
          <option value="corrientes">Corrientes</option>
          <option value="entre-rios">Entre Ríos</option>
          <option value="formosa">Formosa</option>
          <option value="jujuy">Jujuy</option>
          <option value="la-pampa">La Pampa</option>
          <option value="la-rioja">La Rioja</option>
          <option value="mendoza">Mendoza</option>
          <option value="misiones">Misiones</option>
          <option value="neuquen">Neuquén</option>
          <option value="rio-negro">Río Negro</option>
          <option value="salta">Salta</option>
          <option value="san-juan">San Juan</option>
          <option value="san-luis">San Luis</option>
          <option value="santa-cruz">Santa Cruz</option>
          <option value="santa-fe">Santa Fe</option>
          <option value="santiago-del-estero">Santiago del Estero</option>
          <option value="tierra-del-fuego">Tierra del Fuego, Antártida e Islas del Atlántico Sur</option>
          <option value="tucuman">Tucumán</option>
      </select>
      {errors.provinciaRetiro && <span>{errors.provinciaRetiro.message}</span>}

      {/* Referencia */}
      <label htmlFor="referencia">Referencia</label>
      <input
        {...register("referencia", {
          maxLength: {
            value: 200,
            message: "El máximo de caracteres es de 200.",
          },
        })}
        type="text"
      />
      {errors.referencia && <span>{errors.referencia.message}</span>}

      {/* Fecha de Retiro */}
      <label htmlFor="fechaRetiro">Fecha de retiro*</label>
      <input
        {...register("fechaRetiro", {
          required: {
            value: true,
            message: "La fecha de retiro es requerida.",
          },
          validate: (value) => handleFechaRetiro(value),
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
          maxLength: {
            value: 100,
            message: "El máximo de caracteres es de 100.",
          },
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

      {/* Provincia de envío */}
      <label htmlFor="provinciaEnvio">Provincia*</label>
        <select
          defaultValue="cordoba"
          {...register("provinciaEnvio", {
            required: { value: true, message: "Seleccione una provincia." },
          })}
        >
          <option value="" selected disabled>Seleccionar...</option>
          <option value="buenos-aires">Buenos Aires</option>
          <option value="caba">Ciudad Autónoma de Buenos Aires</option>
          <option value="catamarca">Catamarca</option>
          <option value="chaco">Chaco</option>
          <option value="chubut">Chubut</option>
          <option value="cordoba">Córdoba</option>
          <option value="corrientes">Corrientes</option>
          <option value="entre-rios">Entre Ríos</option>
          <option value="formosa">Formosa</option>
          <option value="jujuy">Jujuy</option>
          <option value="la-pampa">La Pampa</option>
          <option value="la-rioja">La Rioja</option>
          <option value="mendoza">Mendoza</option>
          <option value="misiones">Misiones</option>
          <option value="neuquen">Neuquén</option>
          <option value="rio-negro">Río Negro</option>
          <option value="salta">Salta</option>
          <option value="san-juan">San Juan</option>
          <option value="san-luis">San Luis</option>
          <option value="santa-cruz">Santa Cruz</option>
          <option value="santa-fe">Santa Fe</option>
          <option value="santiago-del-estero">Santiago del Estero</option>
          <option value="tierra-del-fuego">Tierra del Fuego, Antártida e Islas del Atlántico Sur</option>
          <option value="tucuman">Tucumán</option>
      </select>
      {errors.provinciaEnvio && <span>{errors.provinciaEnvio.message}</span>}

      {/* Referencia de Envio */}
      <label htmlFor="referenciaEnvio">Referencia</label>
      <input
        {...register("referenciaEnvio", {
          maxLength: {
            value: 200,
            message: "El máximo de caracteres es de 200.",
          },
        })}
        type="text"
      />
      {errors.referenciaEnvio && <span>{errors.referenciaEnvio.message}</span>}

      {/* Fecha de Envio */}
      <label htmlFor="fechaEnvio">Fecha de envío*</label>
      <input
        {...register("fechaEnvio", {
          required: { value: true, message: "La fecha de envío es requerida." },
          validate: (value) => handleFechaEnvio(value),
        })}
        type="date"
      />
      {errors.fechaEnvio && <span>{errors.fechaEnvio.message}</span>}

      {/* Imagenes */}
      <br />
      <lable htmlFor="imagenes">Imágenes</lable>
      <input {...register("imagenes")} type="file" />

      {/* Botones */}
      <button type="submit">Enviar</button>
      <button type="reset">Limpiar</button>

      <pre>{JSON.stringify(watch(), null, 2)}</pre>
    </form>
  );
}

export default App;
