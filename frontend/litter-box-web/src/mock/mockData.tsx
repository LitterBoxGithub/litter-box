import { PetMassSize, PetSpecies, PetVolumeSize } from "../models/enums";

const mockData = {
  mockUsers: [
    {
      id: '5638ac54-7482-4dbd-8f0a-c16a869eeb16',
      email: 'testUser1Email@gmail.com',
      firstName: 'testUser1FirstName',
      lastName: 'testUser1LastName',
    },
    {
      id: '2daed939-4cf9-4d00-ae4c-4c552783e38f',
      email: 'testUser2Email@gmail.com',
      firstName: 'testUser2FirstName',
      lastName: 'testUser2LastName',
    },
    {
      id: '9e1c0e5d-5432-48e9-9e5e-0dc51b73e3e7',
      email: 'testUser3Email@gmail.com',
      firstName: 'testUser3FirstName',
      lastName: 'testUser3LastName',
    },
    {
      id: 'f2b957ad-ef4f-42ce-a7e1-3fc8869c31c9',
      email: 'testUser4Email@gmail.com',
      firstName: 'testUser4FirstName',
      lastName: 'testUser4LastName',
    },
    {
      id: '7c4c6a9c-4b0b-4a56-b53c-9d4005205b46',
      email: 'testUser5Email@gmail.com',
      firstName: 'testUser5FirstName',
      lastName: 'testUser5LastName',
    }
  ],
  mockPets: [
    {
      id: 'c869aa64-8f03-4faa-b4cc-7f27d57b7a3e',
      userId: '5638ac54-7482-4dbd-8f0a-c16a869eeb16',
      name: 'Lyx',
      city: 'testCity1Name',
      petSpecies: PetSpecies.DOG,
      petMassSize: PetMassSize.SMOLBEAN,
      petVolumeSize: PetVolumeSize.SHORTY,
    },
    {
      id: 'b9c3a046-1820-49f2-9a1c-f1809a5d4e2e',
      userId: '5638ac54-7482-4dbd-8f0a-c16a869eeb16',
      name: 'testPet2Name',
      city: 'testCity2Name',
      petSpecies: PetSpecies.CAT,
      petMassSize: PetMassSize.CHOMNK,
      petVolumeSize: PetVolumeSize.GIRAFFENECK,
    },
    {
      id: 'f03f5195-25a2-4b56-ba2f-9b89dfe7f29f',
      userId: '2daed939-4cf9-4d00-ae4c-4c552783e38f',
      name: 'testPet3Name',
      city: 'testCity3Name',
      petSpecies: PetSpecies.DOG,
      petMassSize: PetMassSize.FINEPET,
      petVolumeSize: PetVolumeSize.ITSYBITSY,
    },
    {
      id: 'a7b48e0b-9a3b-4baf-8fb9-7de3a1866c9b',
      userId: '2daed939-4cf9-4d00-ae4c-4c552783e38f',
      name: 'testPet4Name',
      city: 'testCity4Name',
      petSpecies: PetSpecies.BIRD,
      petMassSize: PetMassSize.SMOLBEAN,
      petVolumeSize: PetVolumeSize.SHORTY,
    },
    {
      id: '3e6bc4e2-67e2-4ebf-bc59-90d9565b8f10',
      userId: '9e1c0e5d-5432-48e9-9e5e-0dc51b73e3e7',
      name: 'testPet5Name',
      city: 'testCity5Name',
      petSpecies: PetSpecies.DOG,
      petMassSize: PetMassSize.FINEPET,
      petVolumeSize: PetVolumeSize.ITSYBITSY,
    },
    {
      id: '853f95c7-77e7-494a-b98c-82fe9bbf27a1',
      userId: '9e1c0e5d-5432-48e9-9e5e-0dc51b73e3e7',
      name: 'testPet6Name',
      city: 'testCity6Name',
      petSpecies: PetSpecies.CAT,
      petMassSize: PetMassSize.SMOLBEAN,
      petVolumeSize: PetVolumeSize.SHORTY,
    },
    {
      id: 'eb49a7c9-20a3-43a7-8b79-7989965fe5fe',
      userId: 'f2b957ad-ef4f-42ce-a7e1-3fc8869c31c9',
      name: 'testPet7Name',
      city: 'testCity7Name',
      petSpecies: PetSpecies.DOG,
      petMassSize: PetMassSize.SMOLBEAN,
      petVolumeSize: PetVolumeSize.SHORTY,
    },
    {
      id: 'd1b331cc-2ee3-4d3b-b714-5f79e0f49879',
      userId: 'f2b957ad-ef4f-42ce-a7e1-3fc8869c31c9',
      name: 'testPet8Name',
      city: 'testCity8Name',
      petSpecies: PetSpecies.BIRD,
      petMassSize: PetMassSize.CHOMNK,
      petVolumeSize: PetVolumeSize.GIRAFFENECK,
    },
    {
      id: 'bb1ebf62-827e-4b9d-938b-35fe5354b7e6',
      userId: '7c4c6a9c-4b0b-4a56-b53c-9d4005205b46',
      name: 'testPet9Name',
      city: 'testCity9Name',
      petSpecies: PetSpecies.CAT,
      petMassSize: PetMassSize.FINEPET,
      petVolumeSize: PetVolumeSize.ITSYBITSY,
    },
    {
      id: '3146f7b6-ccff-414d-8310-f5f364b09d52',
      userId: '7c4c6a9c-4b0b-4a56-b53c-9d4005205b46',
      name: 'testPet10Name',
      city: 'testCity10Name',
      petSpecies: PetSpecies.DOG,
      petMassSize: PetMassSize.SMOLBEAN,
      petVolumeSize: PetVolumeSize.SHORTY,
    },
    {
      id: '87c98336-0b3f-4ad3-b739-d8e2e5b6a7a8',
      userId: '7c4c6a9c-4b0b-4a56-b53c-9d4005205b46',
      name: 'testPet11Name',
      city: 'testCity11Name',
      petSpecies: PetSpecies.CAT,
      petMassSize: PetMassSize.FINEPET,
      petVolumeSize: PetVolumeSize.ITSYBITSY,
    },
    {
      id: '22a8d3dd-354c-4ea5-8e82-f4f92d5113e7',
      userId: '7c4c6a9c-4b0b-4a56-b53c-9d4005205b46',
      name: 'testPet12Name',
      city: 'testCity12Name',
      petSpecies: PetSpecies.BIRD,
      petMassSize: PetMassSize.CHOMNK,
      petVolumeSize: PetVolumeSize.GIRAFFENECK,
    },
    {
      beep: 'boop'
    }
  ]
};

export default mockData;