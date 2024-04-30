import React, { useState } from 'react';

function Reset({ text }) {

    const [isHovered, setIsHovered] = useState(false);

    const handleReset = () => {
        // Preguntar
        const confirmReset = window.confirm('¿Está seguro de que desea cancelar? Se perderá toda la información ingresada.');
        if (confirmReset) {
            // Refrescar
            window.location.reload();
        }
    };

    const buttonStyle = {
        backgroundColor: isHovered ? "#2F394B" : "#364156",
        padding: "12px",
        margin: "4px",
        borderRadius: "8px",
        border: "none",
        fontFamily: "Outfit, sans-serif",
        width: "46%",
        fontSize: "20px",
        color: "#DFF8EB"
    }

    return (
        <button
            type="button"
            style={buttonStyle}
            onMouseEnter={() => setIsHovered(true)}
            onMouseLeave={() => setIsHovered(false)}
            onClick={handleReset}
        >
            { text }
        </button>
    )
}

export default Reset;