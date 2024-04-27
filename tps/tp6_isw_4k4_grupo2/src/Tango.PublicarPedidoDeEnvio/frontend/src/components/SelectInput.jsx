import React from 'react';

function SelectInput({ name, label, register, errors, options, defaultValue }) {

  const blockStyle = {
    width: '100%',
    marginTop: '12px'
  }

  const labelStyle = {

  }

  const selectStyle = {
    width: '95%',
    padding: '8px',
    border: 'none',
    borderRadius: '8px',
    marginTop: '2px'
  }

  return (
    <div style={blockStyle}>
      <label style={labelStyle} htmlFor={name}>{label}</label>
      <select
        style={selectStyle}
        defaultValue={defaultValue}
        {...register(name, {
          required: { value: true, message: `Campo obligatorio.` },
        })}
      >
        <option value="" disabled>
          Seleccionar...
        </option>
        {options.map((option, index) => (
          <option key={index} value={option.value}>
            {option.label}
          </option>
        ))}
      </select>
      {errors[name] && <span><br />{errors[name].message}</span>}
    </div>
  );
}

export default SelectInput;
