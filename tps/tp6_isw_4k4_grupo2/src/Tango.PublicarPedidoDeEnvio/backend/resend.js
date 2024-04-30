const { Resend } = require("resend");
const resend = new Resend("re_i8J3gmcr_MTFW9DvQB2sosQxqTFJ4ypTX");
const fs = require("fs");

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
    to: ["alexisjcarnero@gmail.com"],
    subject: "TangoApp",
    html: `
      <p>Datos del formulario:</p>
      <pre>${JSON.stringify(body, null, 2)}</pre>
      <p>Archivos adjuntos:</p>
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
