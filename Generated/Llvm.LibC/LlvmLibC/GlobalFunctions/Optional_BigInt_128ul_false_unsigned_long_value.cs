using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_BigInt_128ul_false_unsigned_long_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm128ELb0EmEEE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::value() &")]
	public unsafe static Anon_izyfb7* Invoke([MangledName("this")] void* This)
	{
		return unchecked((Anon_izyfb7*)(&((Llvm_libc_20_1_2_cpp_optional_neprgb*)This)->Storage.field));
	}
}
