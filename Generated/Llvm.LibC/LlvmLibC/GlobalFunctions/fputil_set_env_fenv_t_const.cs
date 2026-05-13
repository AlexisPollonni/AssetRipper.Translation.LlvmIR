using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7set_envEPK6fenv_t")]
[DemangledName("__llvm_libc_20_1_2_::fputil::set_env(fenv_t const*)")]
internal static partial class fputil_set_env_fenv_t_const
{
	public unsafe static int Invoke(void* envp)
	{
		fputil_internal_X87StateDescriptor fputil_internal_X87StateDescriptor2 = default(fputil_internal_X87StateDescriptor);
		int i = 0;
		int num = 0;
		void* ptr = null;
		int j = 0;
		llvm_lifetime_start_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
		unchecked
		{
			*(short*)(&fputil_internal_X87StateDescriptor2) = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[1] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[2] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[3] = -21846;
			sbyte* ptr2 = (sbyte*)(&fputil_internal_X87StateDescriptor2) + 8;
			*(int*)ptr2 = -1431655766;
			((int*)ptr2)[1] = -1431655766;
			((int*)ptr2)[2] = -1431655766;
			((int*)ptr2)[3] = -1431655766;
			((int*)ptr2)[4] = -1431655766;
			fputil_internal_get_x87_state_descriptor_fputil_internal_X87StateDescriptor.Invoke(&fputil_internal_X87StateDescriptor2);
			int result;
			if (envp == (void*)(-1L))
			{
				short* ptr3 = &fputil_internal_X87StateDescriptor2.status_word;
				*ptr3 = (short)((ushort)(*ptr3) & -64);
				llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < 5; i = checked(i + 1))
				{
					Unsafe.As<InlineArray5_Int32, int>(ref Unsafe.AddByteOffset(ref fputil_internal_X87StateDescriptor2.field, (nint)i * (nint)4)) = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &i);
				short* ptr4 = &fputil_internal_X87StateDescriptor2.control_word;
				*ptr4 = (short)((ushort)(*ptr4) | 0x3F);
				short* ptr5 = &fputil_internal_X87StateDescriptor2.control_word;
				*ptr5 = (short)((ushort)(*ptr5) & -3073);
				short* ptr6 = &fputil_internal_X87StateDescriptor2.control_word;
				*ptr6 = (short)((ushort)(*ptr6) | 0x300);
				fputil_internal_write_x87_state_descriptor_fputil_internal_X87StateDescriptor_const.Invoke(&fputil_internal_X87StateDescriptor2);
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_internal_get_mxcsr.Invoke();
				num &= -64;
				num &= -65;
				num |= 0x1F80;
				num &= -24577;
				num &= -32769;
				fputil_internal_write_mxcsr_unsigned_int.Invoke(num);
				result = 0;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &ptr);
				ptr = envp;
				short* ptr7 = &fputil_internal_X87StateDescriptor2.status_word;
				*ptr7 = (short)((ushort)(*ptr7) & -64);
				int num2 = (ushort)((fputil_internal_FPState*)ptr)->x87_status.status_word & 0x3F;
				short* ptr8 = &fputil_internal_X87StateDescriptor2.status_word;
				*ptr8 = (short)((ushort)(*ptr8) | num2);
				llvm_lifetime_start_p0.Invoke(4L, &j);
				for (j = 0; j < 5; j = checked(j + 1))
				{
					int num3 = ((int*)(&((fputil_internal_FPState*)ptr)->x87_status.field))[j];
					Unsafe.As<InlineArray5_Int32, int>(ref Unsafe.AddByteOffset(ref fputil_internal_X87StateDescriptor2.field, (nint)j * (nint)4)) = num3;
				}
				llvm_lifetime_end_p0.Invoke(4L, &j);
				fputil_internal_X87StateDescriptor2.control_word = ((fputil_internal_FPState*)ptr)->x87_status.control_word;
				fputil_internal_write_x87_state_descriptor_fputil_internal_X87StateDescriptor_const.Invoke(&fputil_internal_X87StateDescriptor2);
				fputil_internal_write_mxcsr_unsigned_int.Invoke(((fputil_internal_FPState*)ptr)->mxcsr);
				result = 0;
				llvm_lifetime_end_p0.Invoke(8L, &ptr);
			}
			llvm_lifetime_end_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
			return result;
		}
	}
}
