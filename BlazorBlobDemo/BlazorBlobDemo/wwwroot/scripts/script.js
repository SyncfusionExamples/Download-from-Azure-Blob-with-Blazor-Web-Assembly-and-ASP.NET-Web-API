export function download(options) {
    var bytes = new Uint8Array(options.byteArray);
    var blob=new Blob([bytes], {type: options.contentType});

    var link=document.createElement('a');
    link.href=window.URL.createObjectURL(blob);
    link.download=options.fileName;
    link.click();
}