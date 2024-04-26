import React from 'react';

function Title({text}) {

  const blockStyle = {
    backgroundColor: '#DFF8EB',
    padding: '3px',
    display: 'flex',
    justifyContent: 'center',
    width: '100%',
    borderRadius: '20px',
    marginBottom: '30px'
  };  

  const titleStyle = {
    color: '#011638'
  }

  return(
    <div style={blockStyle}>
      <h1 style={titleStyle}>{text}</h1>
    </div>
  ); 
}

export default Title;
