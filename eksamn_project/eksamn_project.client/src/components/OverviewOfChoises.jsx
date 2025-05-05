function Overview_Of_Choices({ formData }) {
    return (
        <>
            <p>Opsumering af barsel</p>
            <p>forhold: {formData.RelationshipStatus}</p>
            <p>antal af børn: {formData.AmountOfChildren}</p>
            <p>arbejdssted: {formData.Arbejdsstatus }</p>
            <p>overenskomst: {formData.OverEnskomst ? 'Ja' : 'Nej'}</p>
        </>
    )
}

export default Overview_Of_Choices;