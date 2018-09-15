
//bad code
public void SwitchBattleMode(PlasmaCannons plasmaCannons, Hull hull)
{
    ActivateShields();
    ActivateTargetingSystem();
    hull.OpenPlasmaCannonCovers();
    plasmaCannons.ActivateCoolingSystem();
}

//clean code
public void SwitchBattleMode(PlasmaCannons plasmaCannons, Hull hull)
{
    ActivateShields();
    ActivateTargetingSystem();
    OpenPlasmaCannonCovers(hull);
    ActivateCoolingSystem(plasmaCannons);
}