import React from "react";
import { ToastContainer, Table } from "react-bootstrap";
import Moment from "moment";
import "./MoviesList.css";

function MoviesList(moviesList) {
  return (
    <div>
      <ToastContainer />
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>Cover image</th>
            <th>Title</th>
            <th>Description</th>
            <th>Relase date</th>
          </tr>
        </thead>
        <tbody>
          {moviesList.moviesList?.map((movie) => (
            <tr key={movie.id}>
              <td>  <img src={movie.coverImage} alt="Cover image" id="image" className="movie-cover-image"/></td>
              <td>{movie.title}</td>
              <td>{movie.description}</td>
              <td>{Moment(movie.relaseDate).format("DD/MM/YYYY")}</td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
}

export default MoviesList;
