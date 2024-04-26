import React from 'react';
import moment from "../momentConfig.jsx";

function DateInput({ name, label, register, errors, validate }) {
  return (
    <div>
      <label htmlFor={name}>{label}</label>
      <input
        {...register(name, {
          required: { value: true, message: `Campo obligatorio.` },
          validate: validate,
        })}
        type="date"
      />
      {errors[name] && <span>{errors[name].message}</span>}
    </div>
  );
}

export default DateInput;

