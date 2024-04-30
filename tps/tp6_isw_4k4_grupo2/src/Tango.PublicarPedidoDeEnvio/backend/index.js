const express = require("express");
const multer = require("multer");
const bodyParser = require("body-parser");
const { SendMail } = require("./resend");


const app = express();

// Configuración de multer para cargar archivos
const storage = multer.diskStorage({
  destination: function (req, file, cb) {
    cb(null, "uploads/");
  },
  filename: function (req, file, cb) {
    cb(null, file.originalname);
  },
});
const upload = multer({ storage: storage });

// Middleware para analizar el cuerpo de la solicitud
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

// Ruta para manejar el formulario
app.post("/upload", upload.array("imagenes", 5), (req, res) => {
  // Recibir datos de texto
  const {
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
  } = req.body;


  // Recibir archivos
  const files = req.files;
  console.log(files);
  console.log(req.body);
  SendMail(req.body, files)
  // Hacer algo con los datos y los archivos recibidos
  // Por ejemplo, guardar los archivos en el sistema de archivos
  // files.forEach((file) => {
  //   fs.renameSync(file.path, `uploads/${file.originalname}`);
  // });

  // Responder al cliente
  res.json( "Pedido enviado correctamente!" );
});

// Iniciar el servidor
const PORT = 3000;
app.listen(PORT, () => {
  console.log(`Servidor escuchando en el puerto ${PORT}`);
});
