# /login

* POST /login (username,password) -> return userId

# /profil

* GET /profil/{id} -> return { type: "Developper/projectchief" , profile: {}}
* POST /profil/{id}/associateTechnologies ( [] idTechnology) -> return Profile
* GET /profile/{id}/proposedProjects -> return [] Project
* GET /profile/{id}/acceptedProjects -> return [] Project

# /project

* GET /project/{id} -> return Project
* POST /project (name,description) -> return Project
* GET /project/{id}/technologies -> return [] Technology
* GET /project/{id}/proposedProfiles -> return [] Profile
* GET /project/{id}/acceptedProfiles -> return [] Profile
* GET /project/all -> return [] Project
* GET /project/sharedTechnologiesWithDev/{idDev} -> [] Project
* POST /project/{id}/associateTechnologies ( [] idTechnology) -> return Project
* POST /project/{id}/proposeProfile (idProfile) -> return Project
* GET /project/ownedBy/{idChief} -> return []Project
* POST /project/{id}/acceptProfiles([]idProfile) -> return Project

# /technology

* GET /technology/{id} -> Technology
* POST /technology (name) -> Technology
