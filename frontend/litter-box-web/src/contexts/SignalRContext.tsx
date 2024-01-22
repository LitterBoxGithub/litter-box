import React, { createContext, useEffect, useContext, useState } from "react";
import * as signalR from "@microsoft/signalr";

const SignalRContext = createContext(null);

export const useSignalR = () => {
  return useContext(SignalRContext);
};

export const SignalRProvider = ({ children }) => {
  const [connection, setConnection] = useState(null);

  useEffect(() => {
    const newConnection = new signalR.HubConnectionBuilder()
      .withUrl("your_signalr_hub_url")
      .build();

    newConnection
      .start()
      .then(() => {
        console.log("SignalR connection started");
        setConnection(newConnection);
      })
      .catch((error) =>
        console.error("Error starting SignalR connection:", error)
      );

    return () => {
      if (connection) {
        connection.stop();
      }
    };
  }, []);

  const value = {
    connection,
  };

  return (
    <SignalRContext.Provider value={value}>{children}</SignalRContext.Provider>
  );
};