import React from 'react';

function Subtitle({text}) {

  const blockStyle = {
    display: 'flex',
    justifyContent: 'left',
    width: '100%'
  };  

  const subtitleStyle = {
    color: '#DFF8EB',
    marginBottom: '0px',
    marginTop: '28px'
  }

  return(
    <div style={blockStyle}>
      <h2 style={subtitleStyle}>{text}</h2>
    </div>
  ); 
}

export default Subtitle;