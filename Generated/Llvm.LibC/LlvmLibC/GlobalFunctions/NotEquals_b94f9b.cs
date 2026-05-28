using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NotEquals_b94f9b
{
	[MangledName("_ZN19__llvm_libc_20_1_2_neERKNS_6BigIntILm64ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator!=(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	[CleanName("NotEquals")]
	public unsafe static bool Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Rhs)
	{
		return InstructionHelper.BooleanXor(Equals_tpd9hp.Invoke(Lhs, Rhs), right: true);
	}
}
