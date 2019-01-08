using Common;

namespace EfDbContext
{
    public class MsSqlController
    {
        public MagicBureauEntities GetContext()
        {
            return new MagicBureauEntities();
        }

        public void AddNewSpell(SpellModel spell)
        {
            using (var ctxt = GetContext())
            {
                ctxt.Spells.Add(new Spell
                {
                    SpellName = spell.SpellName,
                    SpellDescription = spell.SpellDescription,
                    SpellText = spell.SpellDescription,
                    SpellAddedDescription = spell.SpellAddedDescription,
                    SpellTypeId = spell.SpellTypeId
                });

                ctxt.SaveChanges();
            }
        }
    }
}
