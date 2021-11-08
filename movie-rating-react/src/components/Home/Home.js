import React, { useEffect, useState } from "react";
import { Tabs, Tab } from "react-bootstrap";
import MoviesList from "../MoviesList/MoviesList";
import { getMoviesByRating } from "../../services/MoviesService";
import { toast } from "react-toastify";
import "./Home.css";

function Home() {
  const [key, setKey] = useState("Movies");
  const [movies, setMovies] = useState([]);
  const [search, setSearch] = useState("");
  const [query, setQuery] = useState();
  const [totalCountMovies, setTotalCountMovies] = useState(0);

  useEffect(() => {
    getMovies();
  }, [key, search]);

  const getMovies = (isButtonMoreLoadClicked) => {
    let params = {};
    params["typeMovie"] = key;
    params["searchQuery"] = search;
   
    if(isButtonMoreLoadClicked){
      params["skipItems"] = movies.length;
    }
    else{
      params["skipItems"] = 0;
    }

    getMoviesByRating(params).then((response) => {
      try {
        let newSetOfMovies = response.data.data;
        if(isButtonMoreLoadClicked){
          setMovies((movies) => [...movies, ...newSetOfMovies]);
        }
        else{
          setMovies(response.data.data);
        }
        setTotalCountMovies(response.data.totalCount);
      } catch {
        toast.error("Sorry, something went wrong!", {
          position: "top-center",
          autoClose: 5000,
          hideProgressBar: true,
        });
      }
    });
  };

  const onHandleChange = (k) => {
    setKey(k);
    setMovies([]);
  };

  const handleSearchChange = (event) => {
    if (event.target.value) {
      if (event.target.value.length >= 2) {
        setSearch(event.target.value);
      }
    } else {
      setSearch(event.target.value);
    }
  };

  const handleLoadMoreClick = () => {
    getMovies(true);
  };

  return (
    <div>
      <div className="inputContainerSearch">
        <i className="fa fa-search icon-search"> </i>
        <input
          className="field-input-search"
          type="text"
          placeholder="Search"
          name="name"
          value={query}
          onChange={handleSearchChange}
        />
      </div>

      <Tabs
        id="controlled-tab-example"
        activeKey={key}
        onSelect={(k) => setKey(k)}
        onSelect={(k) => onHandleChange(k)}
        className="mb-3"
      >
        <Tab eventKey="Movies" title="Movies">
          <MoviesList moviesList={movies} />
        </Tab>
        <Tab eventKey="TV Shows" title="TV Shows">
          <MoviesList moviesList={movies} />
        </Tab>
      </Tabs>
      <button
        type="button"
        onClick={handleLoadMoreClick}
        disabled={movies.length == totalCountMovies}
      >
        View more results
      </button>
    </div>
  );
}

export default Home;
