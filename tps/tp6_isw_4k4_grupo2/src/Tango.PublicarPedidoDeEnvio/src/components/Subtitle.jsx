import React from 'react';

function Subtitle({text}) {

  const blockStyle = {
    display: 'flex',
    justifyContent: 'left',
    width: '100%',
    paddingTop: '24px'
  };  

  const subtitleStyle = {
    color: '#DFF8EB',
    margin: '0px'
  }

  return(
    <div style={blockStyle}>
      <h2 style={subtitleStyle}>{text}</h2>
    </div>
  ); 
}

export default Subtitle;