import React from 'react';

function ImgInput({ register, errors }) {

    const blockStyle = {
        width: '100%',
        marginTop: '24px'
    }

    const labelStyle = {

    }

    const inputStyle = {
        boxSizing: 'border-box',
        padding: '8px',
        border: 'none',
        borderRadius: '8px',
        fontFamily: 'Outfit, sans-serif'
      }

    return (
        <div style={blockStyle}>
            <label htmlFor="imagenes">Imágenes (seleccione hasta 5 simultáneamente)</label>
                <input
                style={inputStyle}
                type="file"
                multiple
                accept=".jpg, .png"
                {...register("imagenes", {
                    validate: (e) => {

                    // Chequea que se seleccionen menos de 5 imágenes
                    if (e.length <= 5 || e.length === undefined) {
                        for (let i = 0; i < e.length; i++) {

                            // Chequea que el archivo sea .jpg o .png
                            if (!e[i].type.includes('image/jpeg') && !e[i].type.includes('image/png')) {
                              return `${e[i].name} no es un archivo de imagen válido. Solo se permiten archivos .jpg y .png.`;
                            }

                            // Chequea que las imágenes pesen menos de 5MB
                            if (e[i].size > 5000000) {
                              return `${e[i].name} es muy grande. Máximo de 5MB por imagen.`;
                            }

                          }
                          return true; // Validación exitosa
                    } else {
                        return "El máximo es de 5 imágenes.";
                    }
                    },
                })}
                />
            {errors.imagenes && (<span><br />{errors.imagenes.message || errors.imagenes}</span>
            )}
        </div>
    )
}

export default ImgInput;