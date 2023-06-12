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
      <motion.div
        drag="x"
        dragConstraints={{ left: 0, right: 0 }}
        onDragEnd={(event, info) => {
          if (info.offset.x > 100) {
            handleSwipeRight();
          } else if (info.offset.x < -100) {
            handleSwipeLeft();
          }
        }}
        variants={variants}
        initial="active"
        animate="active"
        exit="active"
      >
        <Card variant='outlined'>
          <CardContent>
            <CardMedia component="img" image="https://product-images.tcgplayer.com/fit-in/437x437/226586.jpg" />
            <CardActions sx={{justifyContent: 'space-between'}}>
              <IconButton>
                <CancelIcon fontSize='large' />
              </IconButton>
              <IconButton sx={{ float: 'right' }}>
                <FavoriteIcon fontSize='large' />
              </IconButton>
            </CardActions>
          </CardContent>
        </Card>
      </motion.div>
    </Stack>
  );
}

export default MatchingContainer;