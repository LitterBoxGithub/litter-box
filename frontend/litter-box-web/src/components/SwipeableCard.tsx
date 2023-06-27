import React, { useState } from 'react';
import { Card, CardContent } from '@mui/material';

interface SwipeableCardProps {
  title: string;
  description: string;
}

const SwipeableCard: React.FC<SwipeableCardProps> = ({ title, description }) => {
  const [isSwiped, setSwiped] = useState(false);

  const handleMouseDown = () => {
    setSwiped(false);
  };

  const handleMouseUp = () => {
    if (isSwiped) {
      setSwiped(false);
    }
  };

  const handleMouseLeave = () => {
    if (isSwiped) {
      setSwiped(false);
    }
  };

  const handleMouseMove = (e: React.MouseEvent<HTMLDivElement>) => {
    if (e.buttons !== 1) {
      if (isSwiped) {
        setSwiped(false);
      }
    }
  };

  return (
    <Card
      sx={{
        maxWidth: 400,
        margin: 'auto',
        cursor: 'grab',
        userSelect: 'none',
        touchAction: 'none',
        transform: isSwiped ? 'translateX(400px)' : 'none',
        transition: 'transform 0.3s ease-out',
      }}
      onMouseDown={handleMouseDown}
      onMouseUp={handleMouseUp}
      onMouseLeave={handleMouseLeave}
      onMouseMove={handleMouseMove}
      onTouchStart={handleMouseDown}
      onTouchEnd={handleMouseUp}
      onTouchCancel={handleMouseLeave}
    >
      <CardContent>
        <h3>{title}</h3>
        <p>{description}</p>
      </CardContent>
    </Card>
  );
};

export default SwipeableCard;