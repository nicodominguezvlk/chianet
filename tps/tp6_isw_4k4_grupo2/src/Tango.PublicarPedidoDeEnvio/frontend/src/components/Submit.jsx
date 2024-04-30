import React, { useState } from 'react';

function Submit({ text }) {

    const [isHovered, setIsHovered] = useState(false);

    const buttonStyle = {
        backgroundColor: isHovered ? "#EEFBF5" : "#DFF8EB",
        padding: "12px",
        margin: "4px",
        borderRadius: "8px",
        border: "none",
        fontFamily: "Outfit, sans-serif",
        width: "46%",
        fontSize: "20px",
        color: "#011638"
    }

    return (
        <button
            type="submit"
            style={buttonStyle}
            onMouseEnter={() => setIsHovered(true)}
            onMouseLeave={() => setIsHovered(false)}
        >
            { text }
        </button>
    )
}

export default Submit;