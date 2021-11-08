import axios from "axios";

 const url = process.env.REACT_APP_BASE_URL;

const getMoviesByRating = async (params) => {
  return await axios.get(url+'/Movies/GetMoviesByRating', {
    params: {
      typeMovie: params.typeMovie,
      searchQuery:params.searchQuery,
      skipItems:params.skipItems
    }})
};

const getAllMoviesForRate= async () => {
  return await axios.get(url+'/Movies/GetAllMoviesForRate')
};



export { getMoviesByRating, getAllMoviesForRate };