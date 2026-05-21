using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_BigInt_320ul_false_unsigned_long_false_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEE15OptionalStorageIS3_Lb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>, false>::OptionalStorage()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			*(sbyte*)(&((Llvm_libc_20_1_2_cpp_optional_BigInt_320_false_OptionalStorage*)This)->field) = 0;
			((Llvm_libc_20_1_2_cpp_optional_BigInt_320_false_OptionalStorage*)This)->field_1 = 0;
		}
	}
}
