import React from 'react';

function SelectInput({ name, label, register, errors, options, defaultValue }) {
  return (
    <div>
      <label htmlFor={name}>{label}</label>
      <select
        defaultValue={defaultValue}
        {...register(name, {
          required: { value: true, message: `Seleccione su ${label.toLowerCase()}.` },
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
      {errors[name] && <span>{errors[name].message}</span>}
    </div>
  );
}

export default SelectInput;
