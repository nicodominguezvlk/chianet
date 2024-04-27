import moment from "./momentConfig.jsx";
import { useState, useEffect } from "react";
import { useForm } from "react-hook-form";
import Title from "./components/Title";
import Subtitle from "./components/Subtitle";
import SelectInput from "./components/SelectInput";
import TextInput from "./components/TextInput";
import DateInput from "./components/DateInput";

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
      return "No puede haber más de 14 días de diferencia entre el retiro y el envío.";
    } else {
      return true;
    }
  };

  const handleFechaRetiro = (value) => {
    let fechaSelec = new Date(moment(value).format("l")).getTime();
    let fechaActual = new Date(moment().format("l")).getTime();
    let fechaRetiroMax = new Date(
      moment(fechaActual).add(6, "month")
    ).getTime();
    // console.log("actual:",fechaActual,"selec:", fechaSelec)
    if (fechaSelec < fechaActual) {
      return "La fecha debe ser mayor o igual a la fecha actual.";
    }
    if (fechaSelec > fechaRetiroMax) {
      return "No pueden faltar más de 6 meses para el retiro.";
    } else {
      return true;
    }
  };

  const onSubmit = handleSubmit((data) => {
    console.log(data);
  });

  const returnFileSize = (number) => {
    if (number < 1024) {
      return `${number} bytes`;
    } else if (number >= 1024 && number < 1048576) {
      return `${(number / 1024).toFixed(1)} KB`;
    } else if (number >= 1048576) {
      return `${(number / 1048576).toFixed(1)} MB`;
    }
  };

  const tiposDeCarga = [
    { value: "documentacion", label: "Documentación" },
    { value: "paquete", label: "Paquete" },
    { value: "granos", label: "Granos" },
    { value: "hacienda", label: "Hacienda" },
  ];

  const provincias = [
    { value: "buenos-aires", label: "Buenos Aires" },
    { value: "caba", label: "Ciudad Autónoma de Buenos Aires" },
    { value: "catamarca", label: "Catamarca" },
    { value: "chaco", label: "Chaco" },
    { value: "chubut", label: "Chubut" },
    { value: "cordoba", label: "Córdoba" },
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
    {
      value: "tierra-del-fuego",
      label: "Tierra del Fuego, Antártida e Islas del Atlántico Sur",
    },
    { value: "tucuman", label: "Tucumán" },
  ];

  return (
    <form
      id="main"
      method="post"
      encType="multipart/form-data"
      onSubmit={onSubmit}
    >
      <Title text="Publicar pedido de envío" />

      <div id="blockTipoCarga">
        <SelectInput
          name="tipoCarga"
          label="Tipo de carga*"
          register={register}
          errors={errors}
          options={tiposDeCarga}
          defaultValue=""
        />
      </div>

      <div id="contenedor">
        {/* Retiro */}
        <div id="retiro">
          <Subtitle text="Datos de retiro" />

          <TextInput
            name="calleNumRetiro"
            label="Calle y número*"
            register={register}
            errors={errors}
            maxLength={100}
            minLength={4}
            required={true}
          />

          <TextInput
            name="localidadRetiro"
            label="Localidad*"
            register={register}
            errors={errors}
            maxLength={100}
            minLength={4}
            required={true}
          />

          <SelectInput
            name="provinciaRetiro"
            label="Provincia*"
            register={register}
            errors={errors}
            options={provincias}
            defaultValue="cordoba"
          />

          <TextInput
            name="referenciaRetiro"
            label="Referencia"
            register={register}
            errors={errors}
            maxLength={200}
            minLength={0}
            required={false}
          />

          <DateInput
            name="fechaRetiro"
            label="Fecha de retiro*"
            register={register}
            errors={errors}
            validate={handleFechaRetiro}
          />
        </div>

        {/* Envío */}
        <div id="envio">
          <Subtitle text="Datos de envío" />

          <TextInput
            name="calleNumEnvio"
            label="Calle y número*"
            register={register}
            errors={errors}
            maxLength={100}
            minLength={4}
            required={true}
          />

          <TextInput
            name="localidadEnvio"
            label="Localidad*"
            register={register}
            errors={errors}
            maxLength={100}
            minLength={4}
            required={true}
          />

          <SelectInput
            name="provinciaEnvio"
            label="Provincia*"
            register={register}
            errors={errors}
            options={provincias}
            defaultValue="cordoba"
          />

          <TextInput
            name="referenciaEnvio"
            label="Referencia"
            register={register}
            errors={errors}
            maxLength={200}
            minLength={0}
            required={false}
          />

          <DateInput
            name="fechaEnvio"
            label="Fecha de envío*"
            register={register}
            errors={errors}
            validate={handleFechaEnvio}
          />
        </div>
      </div>

      {/* Imagenes */}
      <br />
      <lable htmlFor="imagenes">Imágenes</lable>
      <input
        type="file"
        multiple
        accept="image/*"
        {...register("imagenes", {
          validate: (e) => {
            if ((e.length <= 5 ) || (e.length) === undefined) {
              for(let i = 0; i < e.length; i++ ){
                if(((e[i]).size) > 5000000){
                  return `${e[i].name} muy grande. Max 5mb por imagen.`
                }
              }
              return true
            }else{
              return "Maximo 5 imagenes"
            }
          },
        })}
      />
      {errors.imagenes && <span>{errors.imagenes.message || errors.imagenes}</span>}
      {/* Botones */}
      <button type="submit">Enviar</button>
      <button type="reset">Limpiar</button>

      <pre>{JSON.stringify(watch(), null, 2)}</pre>
    </form>
  );
}

export default App;
