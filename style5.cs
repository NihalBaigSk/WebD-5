body {
    font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
}

.calculator {
    background: #fff;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    width: 320px;
}

.display {
    font-size: 2em;
    background: #222;
    color: #fff;
    padding: 10px;
    border-radius: 5px;
    margin-bottom: 10px;
    text-align: right;
    overflow: hidden;
    text-overflow: ellipsis;
}

.buttons {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 10px;
}

button {
    font-size: 1.5em;
    padding: 20px;
    background: #333;
    color: #fff;
    border: none;
    border-radius: 5px;
    cursor: pointer;
}

button:hover {
    background: #555;
}
