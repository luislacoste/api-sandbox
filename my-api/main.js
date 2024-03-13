const express = require('express');
const app = express();
const port = 3000;

// Middleware to parse JSON
app.use(express.json({ limit: '50mb' }));



function sleep(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}


app.post('/', async (req, res) => {
  if (req.body) {
    
    // Test the timeout
    // await sleep(70000);


    res.json({ message: `Received JSON: ${JSON.stringify(req.body)}` });
    const keys = Object.keys(req.body);

    console.log('-------------------');
    console.log(req.body)
    console.log('-------------------');
  } else {
    res.send('Hello, World!');
  }
});

app.get('/data' ,(req, res) => {

  // Use it to test a large ammount of data
  // let data = require('./large-file.json');

  // Test little data
  let data = [{name: 'test', age: 20}, {name: 'test2', age: 30}]


  res.send(data);
});

// Start the server
app.listen(port, () => {
  console.log(`Server is listening at http://localhost:${port}`);
});

