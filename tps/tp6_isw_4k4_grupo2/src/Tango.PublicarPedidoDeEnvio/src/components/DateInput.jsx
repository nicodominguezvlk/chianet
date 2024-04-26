import React from 'react';
import moment from "../momentConfig.jsx";

function DateInput({ name, label, register, errors, validate }) {

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
      <label style={labelStyle} htmlFor={name}>{label}</label>
      <input
        style={inputStyle}
        {...register(name, {
          required: { value: true, message: `Campo obligatorio.` },
          validate: validate,
        })}
        type="date"
      />
      {errors[name] && <span><br />{errors[name].message}</span>}
    </div>
  );
}

export default DateInput;

