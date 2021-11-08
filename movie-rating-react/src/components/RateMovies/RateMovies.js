import React, { useEffect, useState } from 'react';
import { toast, ToastContainer } from "react-toastify";
import { getAllMoviesForRate } from "../../services/MoviesService";
import { addRateForMovie } from "../../services/RatingService";
import { Table } from "react-bootstrap";
import Moment from "moment";
import StarRatings from 'react-star-ratings';
import "./RateMovies.css";
import "react-toastify/dist/ReactToastify.css";

function RateMovies() {
    const [movies, setMovies] = useState([]);

    useEffect(() => {
        getMovies();
      }, []);
    
      const getMovies = () => {  
        getAllMoviesForRate().then((response) => {
          try {
            setMovies(response.data);
          } catch {
            toast.error("Sorry, something went wrong!", {
              position: "top-center",
              autoClose: 5000,
              hideProgressBar: true,
            });
          }
        });
      };

      const checkAverageForStars=(movie)=>{
        if(movie==null){
            return 0;
        }
           return movie;
      }

      const changeRating=(newRating, name)=>{
        //send newRating as a rate, and name as a movie_Id because "react-star-ratings" receive these attributes as a paramaters
        var data={movie_Id:parseInt(name,10),rate:newRating};
        addRateForMovie(data).then((response) => {
            try {
                toast.success("Movie is successfully rate with star "+ newRating, {
                  position: "top-center",
                  autoClose: 5000,
                  hideProgressBar: true,
                });
                 getMovies();
            }  catch {
              toast.error("Sorry, something went wrong!", {
                position: "top-center",
                autoClose: 5000,
                hideProgressBar: true,
              });
            }
          });

      }
     
    //parse movieID because name parameter in "react-star-ratings"  is a type string
    const parseMovieID=(movieID)=>{
      if(movieID)
      {
         return movieID.toString();
      }
      return '';
    }
    
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
            <th>Rate movie</th>
          </tr>
        </thead>
        <tbody>
          {movies.map((movie) => (
            <tr key={movie.id}>
              <td>  <img src={movie.coverImage} alt="Cover image" id="image" className="movie-cover-image"/></td>
              <td>{movie.title}</td>
              <td>{movie.description}</td>
              <td>{Moment(movie.relaseDate).format("DD/MM/YYYY")}</td>
              <td className="td-of-rating-stars">
                <StarRatings
                          rating={checkAverageForStars(movie.averageRate)}
                          starRatedColor="#f0c764"
                          numberOfStars={5}
                          name={parseMovieID(movie.id)}
                          changeRating={changeRating}
                 />
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
    )
}

export default RateMovies
