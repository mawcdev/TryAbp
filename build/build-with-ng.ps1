echo " Welcome to docker build"
echo ""
echo ""

$ABP_HOST="abp/host"
$ABP_HOST_DOCKERFILE_PATH="src/TryAbp.Web.Host/Dockerfile"
$ABP_NG="abp/ng"

cd ..
echo " Building docker image $ABP_HOST..."
docker build -t $ABP_HOST -f $ABP_HOST_DOCKERFILE_PATH . 
echo " Done. -- Building docker image $ABP_HOST..."
echo ""
echo ""

# echo " Pushing docker image $ABP_HOST..."
# docker push $ABP_HOST
# echo " Done. -- Pushing docker image $ABP_HOST..."
# echo ""
# echo ""