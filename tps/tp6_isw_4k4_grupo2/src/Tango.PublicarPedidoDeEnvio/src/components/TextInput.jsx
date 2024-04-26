import React from 'react';

function TextInput({ name, label, register, errors, maxLength, minLength, required }) {
  return (
    <div>
      <label htmlFor={name}>{label}</label>
      <input
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
