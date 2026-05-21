using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_set_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10set_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::set_except(int)")]
	public unsafe static int Invoke([NativeType("int")] int excepts)
	{
		short num = 0;
		fputil_internal_X87StateDescriptor fputil_internal_X87StateDescriptor2 = default(fputil_internal_X87StateDescriptor);
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = internal_get_status_value_for_except.Invoke(excepts);
		llvm_lifetime_start_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
		unchecked
		{
			*(short*)(&fputil_internal_X87StateDescriptor2) = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[1] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[2] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[3] = -21846;
			sbyte* ptr = (sbyte*)(&fputil_internal_X87StateDescriptor2) + 8;
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)ptr)[2] = -1431655766;
			((int*)ptr)[3] = -1431655766;
			((int*)ptr)[4] = -1431655766;
			internal_get_x87_state_descriptor.Invoke(&fputil_internal_X87StateDescriptor2);
			int num3 = (ushort)num;
			short* ptr2 = &fputil_internal_X87StateDescriptor2.status_word;
			*ptr2 = (short)((ushort)(*ptr2) | num3);
			internal_write_x87_state_descriptor.Invoke(&fputil_internal_X87StateDescriptor2);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_get_mxcsr.Invoke();
			num2 |= (ushort)num;
			internal_write_mxcsr.Invoke(num2);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return 0;
		}
	}
}
