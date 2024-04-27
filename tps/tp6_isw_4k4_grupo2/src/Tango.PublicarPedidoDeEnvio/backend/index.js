import express from "express";
import { Server as SocketServer } from "socket.io";
import http from "http";
import { SendEmail } from "./resend.js";

const app = express();
const server = http.createServer(app);
const io = new SocketServer(server);

const correos = ['alexisjcarnero@gmail.com', 'nic.dom2002@gmail.com']


io.on("connection", (socket) => {
  console.log("Cliente conectado", socket.id);
  socket.on("client:form", (data) =>{
    console.log(data);
    SendEmail(data, correos);
    socket.emit("server:message", "Formulario enviado!")
  })
});

const PUERTO = 3000;
server.listen(PUERTO, () => {
  console.log(`Servidor escuchando en el puerto http://localhost${PUERTO}...`);
});
