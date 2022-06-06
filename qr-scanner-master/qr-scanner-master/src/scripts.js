const uriEjercicio = 'http://localhost:9075/api/Ejercicio/'
const uriUsuario = 'http://localhost:9075/api/Usuario/'
const uriCategoria = 'http://localhost:9075/api/Categoria/'
const uriNoticia = 'http://localhost:9075/api/Noticia/'

//#region EJERCICIO
function getEjercicios(){
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if(this.readyState == 4 && this.status == 200){
            let objetoJson = JSON.parse(this.responseText);
            cargarEjercicios(objetoJson);
        }
    };
    xhttp.open("GET", uriEjercicio, true);
    xhttp.send();
}

function cargarEjercicios(value){
    let contenedor = document.querySelector('#contenedor-ejercicios')
    for(let i = 0; i < value.length; i++){
        let tarjeta = obtenerTarjetaEjercicio(value[i]);
        contenedor.append(tarjeta);
    }
}

function obtenerTarjetaEjercicio(value){
    let tarjeta = document.createElement('div');
    let nombre = document.createElement('h2');
    let descripcion = document.createElement('p');
    let video = document.createElement('iframe');

    tarjeta.setAttribute('id', value['EJE_ID']);
    nombre.textContent = value['EJE_NOMBRE'];
    descripcion.innerHTML = value['EJE_DESCRIPCION'];
    video.setAttribute('width', "600");
    video.setAttribute('height', "340");
    video.setAttribute('src', value['EJE_URLVIDEO']);

    tarjeta.append(nombre, descripcion, video);
    tarjeta.classList = 'tarjeta-ejercicio';
    return tarjeta;
}

function getPorId(uri, id){
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if(this.readyState == 4 && this.status == 200){
            let objetoJson = JSON.parse(this.responseText);
            return objetoJson;
        }
    };
    xhttp.open("GET", uri + id, true);
    xhttp.send();
}
//#endregion

//#region NOTICIA
function getNoticias(){
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if(this.readyState == 4 && this.status == 200){
            let objetoJson = JSON.parse(this.responseText);
            cargarNoticias(objetoJson);
        }
    };
    xhttp.open("GET", uriNoticia, true);
    xhttp.send();
}

function cargarNoticias(value){
    let contenedor = document.querySelector('#contenedor-noticias')
    for(let i = 0; i < value.length; i++){
        let tarjeta = obtenerTarjetaNoticia(value[i]);
        contenedor.append(tarjeta);
    }
}

function obtenerTarjetaNoticia(value){
    let tarjeta = document.createElement('div');

    tarjeta.setAttribute('id', value['NOT_ID']);
    tarjeta.innerHTML = value['NOT_DESCRIPCION'];

    tarjeta.classList = 'tarjeta-noticia';
    return tarjeta;
}
//#endregion



