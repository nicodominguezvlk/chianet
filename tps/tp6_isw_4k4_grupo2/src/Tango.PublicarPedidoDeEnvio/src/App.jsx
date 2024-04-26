import moment from "moment";
import { useState, useEffect } from "react";
import { useForm } from "react-hook-form";
import Title from "./components/Title";
import Subtitle from "./components/Subtitle";
import SelectInput from "./components/SelectInput";

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

  const tiposDeCarga = [
    { value: 'documentacion', label: 'Documentación'},
    { value: 'paquete', label: 'Paquete'},
    { value: 'granos', label: 'Granos'},
    { value: 'hacienda', label: 'Hacienda'}
  ]

  const provincias = [
    { value: "buenos-aires", label: "Buenos Aires" },
    { value: "caba", label: "Ciudad Autónoma de Buenos Aires" },
    { value: "catamarca", label: "Catamarca" },
    { value: "chaco", label: "Chaco" },
    { value: "chubut", label: "Chubut" },
    { value: "cordoba", label: "Córdoba"},
    { value: "corrientes", label: "Corrientes" },
    { value: "entre-rios", label: "Entre Ríos" },
    { value: "formosa", label: "Formosa" },
    { value: "jujuy", label: "Jujuy" },
    { value: "la-pampa", label: "La Pampa" },
    { value: "la-rioja", label: "La Rioja" },
    { value: "mendoza", label: "Mendoza" },
    { value: "misiones", label: "Misiones" },
    { value: "neuquen", label: "Neuquén" },
    { value: "rio-negro", label: "Río Negro" },
    { value: "salta", label: "Salta" },
    { value: "san-juan", label: "San Juan" },
    { value: "san-luis", label: "San Luis" },
    { value: "santa-cruz", label: "Santa Cruz" },
    { value: "santa-fe", label: "Santa Fe" },
    { value: "santiago-del-estero", label: "Santiago del Estero" },
    { value: "tierra-del-fuego", label: "Tierra del Fuego, Antártida e Islas del Atlántico Sur" },
    { value: "tucuman", label: "Tucumán" }
  ];
  

  return (
    <form onSubmit={onSubmit}>
      <Title text="Publicar pedido de envío" />

      <Subtitle text="Datos de retiro" />

      <SelectInput
        name="tipoCarga"
        label="Tipo de carga*"
        register={register}
        errors={errors}
        options={tiposDeCarga}
        defaultValue=""
      />

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
      
      <SelectInput
        name="provinciaRetiro"
        label="Provincia*"
        register={register}
        errors={errors}
        options={provincias}
        defaultValue="cordoba"
      />

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

      <Subtitle text="Datos de envío" />
      
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

      <SelectInput
        name="provinciaEnvio"
        label="Provincia*"
        register={register}
        errors={errors}
        options={provincias}
        defaultValue="cordoba"
      />

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
