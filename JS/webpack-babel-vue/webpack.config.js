
const path = require('path');

module.exports = {
  mode: 'development',
  entry: {
    app: './assets/main.js',
    'bundle.min.css': [
      path.resolve(__dirname, 'assets/css/style.css')
    ],
  },
  output: {
    filename: '[name].js',
    path: __dirname + '/dist'
  },
  module: {
    rules: [
      {
        test: /\.m?js$/,
        use: {
          loader: 'babel-loader',
          options: {
            presets: ['@babel/preset-env']
          }
        }
      }
    ]
  },
  watch: true
};
