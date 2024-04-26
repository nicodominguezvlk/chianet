import React from 'react';

function TextInput({ name, label, register, errors, maxLength, minLength, required }) {

  const blockStyle = {
    width: '100%',
    marginTop: '12px'
  }

  const labelStyle = {

  }

  const inputStyle = {
    boxSizing: 'border-box',
    width: '95%',
    padding: '8px',
    border: 'none',
    borderRadius: '8px',
    marginTop: '2px'
  }

  return (
    <div style={blockStyle}>
      <label style={labelStyle} htmlFor={name}>{label}</label><br />
      <input
        style={inputStyle}
        {...register(name, {
          ...(required && { required: { value: true, message: `Campo obligatorio.` } }),
          ...(minLength && { minLength: { value: minLength, message: `El mínimo de caracteres es de ${minLength}.` } }),
          ...(maxLength && { maxLength: { value: maxLength, message: `El máximo de caracteres es de ${maxLength}.` } }),
        })}
        type="text"
      />
      {errors[name] && <span>{errors[name].message}</span>}
    </div>
  );
}

export default TextInput;
