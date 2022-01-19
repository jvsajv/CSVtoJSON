# CSVtoJSON
 This is an API to convert files from CSV to JSON

# How to use
    Download the project, open with Microsoft Visual Studio and with the code opened you can click Ctrl+F5 or F5 to start the project, automatically the project will open a swagger page where you can upload your file directly clicking in "POST /upload" and then clicking the button "Try it out". When you upload your file .csv you can click "Execute" and you will see the JSON output.

    You can also use ***curl***, see an example below:
        > curl -X POST "https://localhost:44376/upload" -H  "accept: */*" -H  "Content-Type: multipart/form-data" -F "file=@username.csv;type=text/csv"
    Or use any other application as Insomnia or Postman

# Author 
    [jvsajv](https://github.com/jvsajv)

# License

MIT License

Copyright (c) 2020 Francisco Rodrigues

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

# Considerations

This API was based in an existing NodeJS API in this repo: [apiCSV](github.com/chicofariasneto/apiCSV) created by [chicofariasneto](github.com/chicofariasneto)
    
