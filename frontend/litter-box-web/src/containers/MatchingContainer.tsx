import { useContext } from 'react';
import { 
  Card,
  CardActions,
  CardContent,
  CardMedia,
  Stack,
  IconButton
} from '@mui/material';
import FavoriteIcon from '@mui/icons-material/Favorite';
import CancelIcon from '@mui/icons-material/Cancel';
import { motion } from 'framer-motion';
import SwipeableCard from '../components/SwipeableCard';

interface MatchingContainerProps {
  image?: string;
  name?: string;
  description?: string;
  onSwipeRight?: () => void;
  onSwipeLeft?: () => void;
}

const variants = {
  swipeLeft: {
    x: "-100vw",
    opacity: 0,
  },
  swipeRight: {
    x: "100vw",
    opacity: 0,
  },
};

const MatchingContainer: React.FC<MatchingContainerProps> = ({
  image,
  name,
  description,
  onSwipeRight,
  onSwipeLeft,
}) => {

  const handleSwipeRight = () => {
    if (onSwipeRight) {
      onSwipeRight();
    }
  };

  const handleSwipeLeft = () => {
    if (onSwipeLeft) {
      onSwipeLeft();
    }
  };
  
  return (
    <Stack sx={{ 
      overflowX: 'hidden',
    }}>
      <SwipeableCard title={"stuff"} description={"stuff"} />
    </Stack>
  );
}

export default MatchingContainer;