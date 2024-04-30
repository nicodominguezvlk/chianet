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
            <label htmlFor="imagenes">Imágenes</label>
                <input
                style={inputStyle}
                type="file"
                multiple
                accept="image/*"
                {...register("imagenes", {
                    validate: (e) => {
                    if (e.length <= 5 || e.length === undefined) {
                        for (let i = 0; i < e.length; i++) {
                        if (e[i].size > 5000000) {
                            return `${e[i].name} es muy grande. Máximo de 5MB por imagen.`;
                        }
                        }
                        return true;
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