import { Resend } from 'resend';

const resend = new Resend('re_5QxKGSCS_6Ham6ehaTQwbPXSAa9ftwgBT');

export async function SendEmail(form, [correos]) {
  try {
    const data  = await resend.emails.send({
      from: 'TangoApp <onboarding@resend.dev>',
      to: correos,
      subject: 'Pedido de Envio - Tango App',
      html: `${form}`,
    });
    console.log({ data });
  } catch (error) {
    console.log(error);l
  }
};
