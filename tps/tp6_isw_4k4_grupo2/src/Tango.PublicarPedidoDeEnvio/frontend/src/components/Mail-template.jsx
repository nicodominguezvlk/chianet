export const EmailTemplate = ({
  imagenes,
  tipoCarga,
  calleNumRetiro,
  localidadRetiro,
  provinciaRetiro,
  referenciaRetiro,
  fechaRetiro,
  calleNumEnvio,
  localidadEnvio,
  provinciaEnvio,
  referenciaEnvio,
  fechaEnvio,
}) => (
`DATOS DE RETIRO:
  Tipo de Carga: ${tipoCarga},
  Calle y Numero: ${calleNumRetiro},
  Localidad: ${localidadRetiro},
  Provincia: ${provinciaRetiro},
  Referencia: ${referenciaRetiro},
  Fecha:${fechaRetiro}.
  DATOS DE ENVIO:
  Calle y Numero:${calleNumEnvio},
  Localidad: ${localidadEnvio},
  Provincia: ${provinciaEnvio},
  Referencia: ${referenciaEnvio},
  Fecha: ${fechaEnvio}.`
);
