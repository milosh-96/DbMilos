const { createApp } = Vue;

const listTransformer = createApp({
    const commits = ref(null)

    watchEffect(async () => {
        // this effect will run immediately and then
        // re-run whenever currentBranch.value changes
        const url = `${API_URL}${currentBranch.value}`
        commits.value = await(await fetch(url)).json()
    })
});

listTransformer.mount("#list-transformer");