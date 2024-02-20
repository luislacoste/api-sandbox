const express = require('express');
const app = express();
const port = 3000;

// Middleware to parse JSON
app.use(express.json());

// Define a route that returns "Hello, World!" or echoes the received JSON
app.post('/', async (req, res) => {
  if (req.body) {
    await sleep(10000);
    res.json({ message: `Received JSON: ${JSON.stringify(req.body)}` });
    const keys = Object.keys(req.body);
    for (i in keys) {
      console.log(req.body[keys[i]]);
    }
    console.log('-------------------');
    console.log(req.body)
  } else {
    res.send('Hello, World!');
  }
});

app.get('/data' ,(req, res) => {
  res.send([{name:'luis', surname:'Lacoste'}, {name:'Juani', surname:'Fransoy'}]);
});

// Start the server
app.listen(port, () => {
  console.log(`Server is listening at http://localhost:${port}`);
});


function sleep(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}