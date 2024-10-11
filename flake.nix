{
  description = "JS Development Environment with deno and biome";

  inputs.nixpkgs.url = "github:NixOS/nixpkgs/nixos-unstable";

  outputs = { self, nixpkgs, ... }:
    let
      pkgs = import nixpkgs { system = "x86_64-linux"; }; 
    in
    {
      devShell.x86_64-linux = pkgs.mkShell {
        buildInputs = with pkgs; [
	  deno biome prettierd
        ];

        shellHook = ''
          echo "Welcome to the JS development environment!"
        '';
      };
    };
}

