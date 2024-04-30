const { Resend } = require("resend");
const resend = new Resend("re_i8J3gmcr_MTFW9DvQB2sosQxqTFJ4ypTX");
const fs = require("fs");

const correos = ["alexisjcarnero@gmail.com"]

async function SendMail(body, files) {
  // Obtener la lista de nombres de archivos de las imágenes
  const imageFileNames = files.map((file) => file.originalname);

  const attachments = await Promise.all(
    files.map(async (file) => ({
      filename: file.originalname,
      content: await fs.promises.readFile(file.path),
    }))
  );

  const { data, error } = await resend.emails.send({
    from: "TangoApp <onboarding@resend.dev>",
    to: correos,
    subject: "TangoApp",
    html: `
      <h1>Pedido de Envio:</h1>
      <h2>Datos de Envio</h2>
      <p>Tipo de Carga: ${body.tipoCarga}</p>
      <p>Calle y Numero: ${body.calleNumRetiro}</p>
      <p>Localidad: ${body.localidadRetiro}</p>
      <p>Provincia: ${body.provinciaRetiro}</p>
      <p>Fecha de Retiro: ${body.fechaRetiro}</p>
      <h2>Datos de Envio</h2>
      <p>Calle y Numero: ${body.calleNumEnvio}</p>
      <p>Localidad: ${body.localidadEnvio}</p>
      <p>Provincia: ${body.provinciaEnvio}</p>
      <p>Fecha de Retiro: ${body.fechaEnvio}</p>
      <h3>Archivos adjuntos:</h3>
      <ul>
        ${imageFileNames.map((fileName) => `<li>${fileName}</li>`).join("")}
      </ul>
    `,
    attachments,
  });

  if (error) {
    return console.error({ error });
  }

  console.log({ data });
}

module.exports = { SendMail };
