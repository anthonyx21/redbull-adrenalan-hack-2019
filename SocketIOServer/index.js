// var app = require('express')()

var express = require('express')
const bodyParser = require('body-parser')

var app = express()
app.use(bodyParser.json())

var server = require('http').Server(app)
var io = require('socket.io')(server)

server.listen(3001)

app.get('/', (req, res) => {
  res.json({ status: 'ok' })
})

app.post('/say', (req, res) => {
  console.log('bb', req.body)
  io.emit('message', { speech: req.body.speech })
  res.json({ status: 'ok' })
})

app.post('/do', (req, res) => {
  console.log('bb', req.body)
  io.emit('message', { speech: req.body.action })
  res.json({ status: 'ok' })
})

io.on('connection', (socket) => {
  console.log('user connected')

  socket.on('message', function (data) {
    console.log(data)
  })

  socket.on('doneSpeaking', function (data) {
    console.log('done speaking')
    io.emit('doneSpeaking')
  })

  socket.on('disconnect', function (data) {
    console.log('user disconnected')
  })
})

console.log('server running')
