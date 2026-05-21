using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_sub_overflow
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjE12sub_overflowERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::sub_overflow(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_vtm4cw* This, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&")] Llvm_libc_20_1_2_BigInt_vtm4cw* Rhs)
	{
		return Multiword_sub_with_borrow_unsigned_int_1ul_1ul.Invoke(&This->Val, &Rhs->Val);
	}
}
